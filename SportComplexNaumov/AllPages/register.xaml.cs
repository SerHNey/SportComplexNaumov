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
    /// Логика взаимодействия для register.xaml
    /// </summary>
    public partial class register : Page
    {
        public register()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Users authUser = new Users();
            string fio = txtfio.Text.Trim();
            string phone = txtphone.Text.Trim();
            string email = txtemail.Text.Trim();
            string login = txtlogin.Text.Trim();
            string pass = txtPass.Password.Trim();

            var block = sfio.Children.OfType<TextBox>().ToList().
                Concat(sphone.Children.OfType<TextBox>().ToList()).
                Concat(registers.Children.OfType<TextBox>().ToList());


            foreach (TextBox item in block)
            {
               if(item.Text.Length < 4)
               {
                    item.BorderBrush = Brushes.DarkRed;

               }
               else
                    item.BorderBrush = Brushes.Gray;
            }
            using (EntitiesComplex context = new EntitiesComplex())
            {
                authUser.name = fio;
                authUser.phone = phone;
                authUser.email = email;
                authUser.login = login;
                authUser.password = pass;
                EntitiesComplex.GetContext().Users.Add(authUser);
                EntitiesComplex.GetContext().SaveChanges();
            }

            //if (fio.Length < 4)
            //{
            //    txtfio.ToolTip = "Введите ФИО";
            //    txtfio.Background = Brushes.DarkRed;
            //}
            //else
            //{
            //    txtfio.Background = Brushes.Transparent;
            //    authUser.name = fio;
            //}  
            //if (phone.Length < 4)
            //{
            //    txtphone.ToolTip = "Введите номер телефона";
            //    txtphone.Background = Brushes.DarkRed;
            //}
            //else
            //{
            //    txtphone.Background = Brushes.Transparent;
            //    authUser.phone = phone;
            //}
            //if (login.Length < 4)
            //{
            //    txtlogin.ToolTip = "Введие логин";
            //    txtlogin.Background = Brushes.DarkRed;
            //}
            //else
            //{
            //    txtlogin.Background = Brushes.Transparent;
            //    authUser.login = login;

            //}
            //if (email.Length < 4)
            //{
            //    txtemail.ToolTip = "Введие электронную почту";
            //    txtemail.Background = Brushes.DarkRed;
            //    authUser.email = email;
            //}
            //else
            //{
            //    txtemail.Background = Brushes.Transparent;
            //}
            //if (pass.Length < 4)
            //{
            //    txtPass.ToolTip = "Введите пароль";
            //    txtPass.Background = Brushes.DarkRed;
            //}
            //else
            //{
            //    txtPass.Background = Brushes.Transparent;
            //    authUser.password = pass;
            //}



            //if (login.Length < 4)
            //{

            //}

            //else if (pass.Length < 4)
            //{
            //    txtPass.ToolTip = "Логин либо пароль введенны не правильно.";
            //    txtPass.Background = Brushes.DarkRed;
            //}
            //else
            //{
            //    txtlogin.ToolTip = "";
            //    txtlogin.Background = Brushes.Transparent;
            //    txtPass.ToolTip = "";
            //    txtPass.Background = Brushes.Transparent;



            //if (authUser != null)
            //{
            //    MessageBox.Show("Все данные введены верно");
            //    Manager.MainFrame.Navigate(new AllPages.section());
            //}

            //else
            //    MessageBox.Show("Вы ввели не правильные данные");
        }
    }
    
}
