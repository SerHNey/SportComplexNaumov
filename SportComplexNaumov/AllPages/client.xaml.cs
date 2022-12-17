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
using SportComplexNaumov.AllClass;
using SportComplexNaumov.Entity;

namespace SportComplexNaumov.AllPages
{
    /// <summary>
    /// Логика взаимодействия для client.xaml
    /// </summary>
    public partial class client : Page
    {
        Client clientt = new Client();
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
            if (clientt != null)
            {
                try
                {
                    
                    clientt.name = client_name.Text;
                    clientt.phone = client_email.Text;
                    clientt.email = client_phone.Text;
                    EntitiesComplex.GetContext().SaveChanges();
                    MessageBox.Show("Запись добавленна");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                try
                {
                    clinet.name = client_name.Text;
                    clinet.phone = client_email.Text;
                    clinet.email = client_phone.Text;
                    EntitiesComplex.GetContext().Client.Add(clinet);
                    EntitiesComplex.GetContext().SaveChanges();
                    MessageBox.Show("Запись добавленна");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

            clientt = ((sender as Button).DataContext as Client);
            client_name.Text = clientt.name;
            client_email.Text = clientt.email;
            client_phone.Text = clientt.phone;

           
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
