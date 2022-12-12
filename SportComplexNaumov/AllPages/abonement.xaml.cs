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
        private Abonement _currentabonement = new Abonement();
        public abonement()
        {
            InitializeComponent();
            DGridAbonement.ItemsSource = EntitiesComplex.GetContext().Abonement.ToList();

            
        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (_currentabonement.id_section == null)
                errors.AppendLine("Укажите название секции");
            if (_currentabonement.id_client == null)
                errors.AppendLine("Укажите клиента");
            if (_currentabonement.Instryctor == null)
                errors.AppendLine("Выберете инструктора");
            if (_currentabonement.date == null)
                errors.AppendLine("Выберете время");
            if (_currentabonement.price == null)
                errors.AppendLine("Укажите цену");
            if (_currentabonement.discount == null)
                errors.AppendLine("Укажите цену");

            try
            {
                EntitiesComplex.GetContext().Abonement.Add(_currentabonement);
                EntitiesComplex.GetContext().SaveChanges();
                MessageBox.Show("Запись добавленна");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }



            //string abonent = txt.Text.Trim();hone.Text.Trim();
            //string email = txtemail.Text.Trim();
            //string login = txtlogin.Text.Trim();
            //string pass = txtPass.Password.Trim();

            //Users authUser = new Users();
            //using (EntitiesComplex context = new EntitiesComplex())
            //{
            //    authUser.abonent = fio;
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
