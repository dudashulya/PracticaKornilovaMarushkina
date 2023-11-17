using PracticaKornilovaMarushkina.Components;
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
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void EnterBTN_Click(object sender, RoutedEventArgs e)
        {
            var User = BDConnection.connection.Employee.Where(x => x.Id_Number.ToString() == PasswordPB.Password).FirstOrDefault() as Employee;
                if (BDConnection.connection.Boss.Where(x => x.Id_Boss.ToString() == PasswordPB.Password).FirstOrDefault() != null)
                {
                    App.isHeadDepartment = true;
                    MessageBox.Show("Здравствуй Заведующий Кафедры");
                    
                }
                else if (BDConnection.connection.Engineer.Where(x => x.Id_Engineer.ToString() == PasswordPB.Password).FirstOrDefault() != null)
                {
                     App.isEngineer = true;
                InfoUser.IDEmploy = Convert.ToInt32(PasswordPB.Password);
                     MessageBox.Show("Здравствуй Инженер");
                     Navigation.NextPage(new PageComponents("Список услуг", new EmployeePage()));
                }
           else if (BDConnection.connection.Employee.Where(x => x.Id_Number.ToString() == PasswordPB.Password && x.Id_Rank.ToString() != null).FirstOrDefault() != null)
            {
                App.isTeacher = true;
                MessageBox.Show("Здравствуй Преподаватель");

            }
            else if (BDConnection.connection.Student.Where(x => x.Id_Student.ToString() == PasswordPB.Password ).FirstOrDefault() != null)
                {
                InfoUser.IdStudent =Convert.ToInt32( PasswordPB.Password);
                    MessageBox.Show("Здравствуй студент");
                    Navigation.NextPage(new PageComponents("Список услуг", new DisciplinesPage()));
                }

            else
            {  
                
               MessageBox.Show("Неверный пароль. Попробуйте заново");
                

            }
              

            

        }
    }
}
