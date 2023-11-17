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
        public static int IDEmploy 
        {
            get;
            set;
        }
        public static int IDBoss
        {
            get;
            set;
        }
        public static int IDTeacher
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
            last.Text = BDConnection.connection.Student.Where(x => x.Id_Student == InfoUser.IdStudent).FirstOrDefault().LastName_Student;
                //Convert.ToString(InfoUser.IdStudent);
            DataContext = this;

        }

       
    }
}
