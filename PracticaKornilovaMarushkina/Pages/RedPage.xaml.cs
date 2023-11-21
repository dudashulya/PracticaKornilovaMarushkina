using PracticaKornilovaMarushkina.DataBase;
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


namespace PracticaKornilovaMarushkina.Pages
{
    /// <summary>
    /// Логика взаимодействия для RedPage.xaml
    /// </summary>
    public partial class RedPage : Page
    {
        private Departament departament;
        public RedPage(Departament _department)
        {
            InitializeComponent();
            departament = _department;
            this.DataContext = departament;
        }
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();//создание строки ошибки 

            if (departament.Cipher != null)
            {
                if (BDConnection.connection.Departament.Any(x => x.Name_Departament == departament.Name_Departament))
                {
                    error.AppendLine("Такая сотрудник УЖЕ есть!!!!!!!!!!!!");
                    MessageBox.Show(error.ToString());
                }
                else
                {
                    BDConnection.connection.Departament.Add(departament);

                }
            }
            if (error.Length > 0)
            {
                MessageBox.Show(error.ToString());
                return;
            }
            BDConnection.connection.SaveChanges();


            MessageBox.Show("Сохранено");
            Navigation.NextPage(new PageComponents("Список услуг", new DepartmentPage()));

        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, (0)))
            {
                e.Handled = true;
            }
        }
    }
}
