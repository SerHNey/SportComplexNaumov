using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SportComplexNaumov.Entity;

namespace SportComplexNaumov.AllPages
{
    /// <summary>
    /// Логика взаимодействия для client.xaml
    /// </summary>
    public partial class client : Page
    {
        public client()
        {
            InitializeComponent();
            DGridClient.ItemsSource = EntitiesComplex.GetContext().Client.ToList();
        }

        private void btnAbonement_Click(object sender, RoutedEventArgs e)
        {
            Client clinet = new Client();
            if (client_name.Text == null)
                MessageBox.Show("Введите имя");
            
            if (client_phone.Text == null)
                MessageBox.Show("Введите телефон");
            if (client_email.Text == null)
                MessageBox.Show("Введите почта");

            try
            {
                clinet.name = client_name.Text;
                clinet.phone = client_phone.Text;
                clinet.email = client_email.Text;
                EntitiesComplex.GetContext().Client.Add(clinet);
                EntitiesComplex.GetContext().SaveChanges();
                MessageBox.Show("Запись добавленна");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btndel_Click(object sender, RoutedEventArgs e)
        {
            var hotelsForRemoving = DGridClient.SelectedItems.Cast<Client>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {hotelsForRemoving.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    EntitiesComplex.GetContext().Client.RemoveRange(hotelsForRemoving);
                    EntitiesComplex.GetContext().SaveChanges();
                    MessageBox.Show("Даныые удалены");
                    DGridClient.ItemsSource = EntitiesComplex.GetContext().Client.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
