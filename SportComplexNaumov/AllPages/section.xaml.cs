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
using Section = SportComplexNaumov.Entity.Section;

namespace SportComplexNaumov.AllPages
{
    /// <summary>
    /// Логика взаимодействия для section.xaml
    /// </summary>
    public partial class section : Page
    {
        public section()
        {
            InitializeComponent();
            DGridSection.ItemsSource = EntitiesComplex.GetContext().Section.ToList();
        }

        private void btnAbonement_Click(object sender, RoutedEventArgs e)
        {
            Entity.Section section = new Entity.Section();
            if (sec_sec.Text == null)
                MessageBox.Show("Введите имя");

            if (sec_tren.Text == null)
                MessageBox.Show("Введите телефон");

            try
            {
              
                EntitiesComplex.GetContext().SaveChanges();
                MessageBox.Show("Запись добавленна");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btndel_Click(object sender, RoutedEventArgs e)
        {
            var hotelsForRemoving = DGridSection.SelectedItems.Cast<Section>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {hotelsForRemoving.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    EntitiesComplex.GetContext().Section.RemoveRange(hotelsForRemoving);
                    EntitiesComplex.GetContext().SaveChanges();
                    MessageBox.Show("Даныые удалены");
                    DGridSection.ItemsSource = EntitiesComplex.GetContext().Section.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
