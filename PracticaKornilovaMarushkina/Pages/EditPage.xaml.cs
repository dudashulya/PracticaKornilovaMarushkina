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
using PracticaKornilovaMarushkina.DataBase;
using PracticaKornilovaMarushkina;


namespace PracticaKornilovaMarushkina.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        private Employee employee;
        public EditPage(Employee _employee)
        {
            InitializeComponent();
            employee = _employee;
            this.DataContext = employee;
            
        }
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();//создание строки ошибки 

            if (employee.Id_Number == 0)
            {
                if (BDConnection.connection.Employee.Any(x => x.LastName == employee.LastName))
                {
                    error.AppendLine("Такая сотрудник УЖЕ есть!!!!!!!!!!!!");
                    MessageBox.Show(error.ToString());
                }
                else
                {
                    BDConnection.connection.Employee.Add(employee);
                }
            }
            if (error.Length > 0)
            {
                MessageBox.Show(error.ToString());
                return;
            }
            BDConnection.connection.SaveChanges();


            MessageBox.Show("Сохранено");
            Navigation.NextPage(new PageComponents("Список услуг", new EmployeePage()));

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
