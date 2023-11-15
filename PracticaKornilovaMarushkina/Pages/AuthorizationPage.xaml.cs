using PracticaKornilovaMarushkina.Components;
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
            
                if (PasswordPB.Password == "0000")
                {
                    App.isHeadDepartment = true;
                    MessageBox.Show("Здравствуй Заведующий Кафедры");
                }
                if (PasswordPB.Password == "1111")
                {
                     App.isEngineer = true;
                     MessageBox.Show("Здравствуй Инженер");
                }
                if (PasswordPB.Password == "2222")
                {
                     App.isTeacher = true;
                     MessageBox.Show("Здравствуй Преподаватель");
                }
                else if(PasswordPB.Password == "")
                {
                    MessageBox.Show("Здравствуй гость");
                }
              Navigation.NextPage(new PageComponents("Список услуг", new DisciplinesPage()));

            

        }
    }
}
