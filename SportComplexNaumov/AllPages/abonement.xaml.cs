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
    /// Логика взаимодействия для abonement.xaml
    /// </summary>
    public partial class abonement : Page
    {
        public abonement()
        {
            InitializeComponent();
            DGridAbonement.ItemsSource = EntitiesComplex.GetContext().Abonement.ToList();
            Combosection.ItemsSource = EntitiesComplex.GetContext().Cekcia.ToList();
            ComboClentt.ItemsSource = EntitiesComplex.GetContext().Client.ToList();
            Comboinstryctorr.ItemsSource = EntitiesComplex.GetContext().Instryctor.ToList();
            
        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {



            Users authUser = new Users();
            //using (EntitiesComplex context = new EntitiesComplex())
            //{
            //    authUser.name = fio;
            //    authUser.phone = phone;
            //    authUser.email = email;
            //    authUser.login = login;
            //    authUser.password = pass;
            //    EntitiesComplex.GetContext().Users.Add(authUser);
            //    EntitiesComplex.GetContext().SaveChanges();
            //}
        }
    }
}
