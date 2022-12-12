using SportComplexNaumov.AllClass;
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

namespace SportComplexNaumov.AllPages
{
    /// <summary>
    /// Логика взаимодействия для menu.xaml
    /// </summary>
    public partial class menu : Page
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btnAbonement_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AllPages.abonement());
        }

        private void bntClient_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AllPages.client());
        }

        private void bntInstructor_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AllPages.instryctor());
        }

        private void bntSection_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AllPages.section());
        }

        private void bntTrenirovki_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AllPages.trenirovki());
        }
    }
}
