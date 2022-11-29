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
using SportComplexNaumov.Entity;

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
            string login = txtUser.Text.Trim();
            string pass = txtPass.Password.Trim();


            if (login.Length < 1)
            {
                txtUser.ToolTip = "Логин либо пароль введенны не правильно.";
                txtUser.Background = Brushes.DarkRed;
            }
            else if (pass.Length < 1)
            {
                txtPass.ToolTip = "Логин либо пароль введенны не правильно.";
                txtPass.Background = Brushes.DarkRed;
            }
            else
            {
                txtUser.ToolTip = ""; txtUser.Background = Brushes.Transparent;
                txtPass.ToolTip = ""; txtPass.Background = Brushes.Transparent;

                Users authUser = null;
                using (EntitiesComplex context = new EntitiesComplex())
                {
                    authUser = context.Users.Where(b => b.login == login && b.password == pass).FirstOrDefault();
                }

                if (authUser != null)
                {
                    MessageBox.Show("Все данные введены верно");
                    Manager.MainFrame.Navigate(new AllPages.abonement());
                }
                    
                else
                    MessageBox.Show("Вы ввели не правильные данные");
            }
        }
        private void gotologin_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AllPages.register());
        }
    }
}
