using PracticaKornilovaMarushkina.DataBase;
using System;
using System.Collections;
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
    /// Логика взаимодействия для EmployeePage.xaml
    /// </summary>
    public partial class EmployeePage : Page
    {
        
        public EmployeePage( )
        {
            InitializeComponent();
            EList.ItemsSource = BDConnection.connection.Employee.ToList();
            
           
        }
        private void SerchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }
        private void Refresh()
        {
            IEnumerable<Employee> EmployeeeSortList = BDConnection.connection.Employee;
            if (SerchTb.Text != null)
            {
                EmployeeeSortList = EmployeeeSortList.Where(x => x.LastName.ToLower().Contains(SerchTb.Text.ToLower()) || x.LastName.ToLower().Contains(SerchTb.Text.ToLower())); //поиск по слову
                   EList.ItemsSource = EmployeeeSortList;   
            }

            CountDataTb.Text = EmployeeeSortList.Count() + "из" + BDConnection.connection.Employee.Count();// выводить сколько данных показывается из всех
           
           

        }
    }
}
