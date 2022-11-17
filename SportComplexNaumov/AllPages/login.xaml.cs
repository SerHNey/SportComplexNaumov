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
    /// Логика взаимодействия для login.xaml
    /// </summary>
    public partial class login : Page
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnMinsize_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void gotologin_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AllPages.register());
        }
    }
}
