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
    /// Логика взаимодействия для DisciplinesPage.xaml
    /// </summary>


    public class InfoUser
    {
       public static int IdStudent
        {
            get;
            set;
        }
    }
    public partial class DisciplinesPage : Page
    {
        Student student;
        public DisciplinesPage()
        {
            InitializeComponent();
            BList.ItemsSource = BDConnection.connection.StudentDiscipline.Where(x => x.Id_Student == InfoUser.IdStudent).ToList();
            DataContext = this;
        }

        private void SerchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }
        private void Refresh()
        {
            IEnumerable<Discipline> DisciplineSortList = BDConnection.connection.Discipline;
            if (SerchTb.Text != null)
            {
                DisciplineSortList = DisciplineSortList.Where(x => x.Name_Discipline.ToLower().Contains(SerchTb.Text.ToLower()) || x.Name_Discipline.ToLower().Contains(SerchTb.Text.ToLower())); //поиск по слову
            }

            CountDataTb.Text = DisciplineSortList.Count() + "из" + BDConnection.connection.Discipline.Count();// выводить сколько данных показывается из всех


        }
    }
}
