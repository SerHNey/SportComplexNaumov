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
    /// Логика взаимодействия для instryctor.xaml
    /// </summary>
    public partial class instryctor : Page
    {
        public instryctor()
        {
            InitializeComponent();
            DGridInstryctor.ItemsSource = EntitiesComplex.GetContext().Instryctor.ToList();
        }

        private void btnAbonement_Click(object sender, RoutedEventArgs e)
        {
            Instryctor instryctor = new Instryctor();
            if (instr_name.Text == null)
                MessageBox.Show("Введите имя");

            if (instr_phone.Text == null)
                MessageBox.Show("Введите телефон");
            if (instr_email.Text == null)
                MessageBox.Show("Введите почта");

            try
            {
                instryctor.name_instryctora = instr_name.Text;
                instryctor.phone = instr_phone.Text;
                instryctor.email = instr_email.Text;
                EntitiesComplex.GetContext().Instryctor.Add(instryctor);
                EntitiesComplex.GetContext().SaveChanges();
                MessageBox.Show("Запись добавленна");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
