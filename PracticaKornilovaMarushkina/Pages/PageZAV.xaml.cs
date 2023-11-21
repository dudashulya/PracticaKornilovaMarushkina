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
    /// Логика взаимодействия для PageZAV.xaml
    /// </summary>
    public partial class PageZAV : Page
    {
        public PageZAV()
        {
            InitializeComponent();
            ZList.ItemsSource = BDConnection.connection.Discipline.ToList();
        }
        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            Discipline discipline = ZList.SelectedItem as Discipline;
            Navigation.NextPage(new PageComponents("Редактирование", new PageDis(discipline)));
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            Discipline discipline = ZList.SelectedItem as Discipline;
            if (discipline!= null)
            {
                BDConnection.connection.Discipline.Remove(discipline);
                BDConnection.connection.SaveChanges();
                ZList.ItemsSource = BDConnection.connection.Discipline.ToList();
            }
            
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Discipline discipline = new Discipline();
            Navigation.NextPage(new PageComponents("Редактирование", new PageDis(discipline)));
        }
    }
    }
