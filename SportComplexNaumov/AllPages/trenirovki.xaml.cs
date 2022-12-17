using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Логика взаимодействия для trenirovki.xaml
    /// </summary>
    public partial class trenirovki : Page
    {
        List<Trenirovki> list;
        public trenirovki()
        {
            InitializeComponent();
            list = EntitiesComplex.GetContext().Trenirovki.ToList();
            DGridTrenirovki.ItemsSource = EntitiesComplex.GetContext().Trenirovki.ToList();

            //DGridTrenirovki.ItemsSource = list;
            //Console.Write(list.Count);
            //Thread myThread1 = new Thread(Print);
            //myThread1.Start();


        }

        //void Print()
        //{
        //    int count = list.Count;
        //    while (true)
        //    {
        //        if (list.Count > count && list.Last().name_trenirovki != null)
        //        {
        //            EntitiesComplex.GetContext().Trenirovki.Add(list.Last());
        //            EntitiesComplex.GetContext().SaveChanges();
        //            count++;
        //        }
        //    }
        //}


        private void btnAbonement_Click(object sender, RoutedEventArgs e)
        {
            Trenirovki trenirovki = new Trenirovki();
            if (trenirov == null)
            {
                MessageBox.Show("Введите название");
            }
            try
            {
                trenirovki.name_trenirovki = trenirov.Text;

                EntitiesComplex.GetContext().Trenirovki.Add(trenirovki);
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
            var hotelsForRemoving = DGridTrenirovki.SelectedItems.Cast<Trenirovki>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {hotelsForRemoving.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    EntitiesComplex.GetContext().Trenirovki.RemoveRange(hotelsForRemoving);
                    EntitiesComplex.GetContext().SaveChanges();
                    MessageBox.Show("Даныые удалены");
                    DGridTrenirovki.ItemsSource = EntitiesComplex.GetContext().Trenirovki.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtnEit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
