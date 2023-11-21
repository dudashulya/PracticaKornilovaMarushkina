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
using PracticaKornilovaMarushkina;

namespace PracticaKornilovaMarushkina.Pages
{
    /// <summary>
    /// Логика взаимодействия для DepartmentPage.xaml
    /// </summary>
    public partial class DepartmentPage : Page
    {
      
        public DepartmentPage()
        {
            InitializeComponent();
          
            DList.ItemsSource = BDConnection.connection.Departament.ToList();
            DataContext = this;
        }

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            Departament departament = DList.SelectedItem as Departament;
            if(departament != null)
                Navigation.NextPage(new PageComponents("Редактирование", new RedPage(departament)));
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            Departament departament = DList.SelectedItem as Departament;
            if(departament != null)
                BDConnection.connection.Departament.Remove(departament);
            BDConnection.connection.SaveChanges();
            DList.ItemsSource = BDConnection.connection.Departament.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Navigation.NextPage(new PageComponents("Редактирование", new RedPage(new Departament())));
        }
    }
}
