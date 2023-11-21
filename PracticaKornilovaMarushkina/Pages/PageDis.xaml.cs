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
//using PracticaKornilovaMarushkina;

namespace PracticaKornilovaMarushkina.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageDis.xaml
    /// </summary>
    public partial class PageDis : Page
    {
        private Discipline discipline;
        bool newu;
        public PageDis(Discipline disciplinE)
        {
            InitializeComponent();
            discipline = disciplinE;
            this.DataContext = discipline;
            if (discipline.Id_Discipline == 0)
                newu = true;
            else newu = false;
        }
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();//создание строки ошибки 

            if (BDConnection.connection.Discipline.Any(x => x.Name_Discipline == discipline.Name_Discipline) && newu == true)
            {
                MessageBox.Show("Такая сотрудник УЖЕ есть!!!!!!!!!!!!");
                return;
            }
            else if(newu == true)
            {
                BDConnection.connection.Discipline.Add(discipline);
            }
            BDConnection.connection.SaveChanges();
            MessageBox.Show("Сохранено");
            Navigation.NextPage(new PageComponents("Список услуг", new PageZAV()));
            //NavigationService.Navigate(new PageZAV());
        }

        //private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        //{
        //    if (!char.IsDigit(e.Text, (0)))
        //    {
        //        e.Handled = true;
        //    }
        //}
    }
}
