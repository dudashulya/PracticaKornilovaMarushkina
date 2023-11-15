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
    public partial class DisciplinesPage : Page
    {
        public DisciplinesPage()
        {
            InitializeComponent();
        }

        private void SerchTb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        //private void Refresh()
        //    IEnumerable<Service> serviceSortList = App.db.Service;
        //{ 
        //    if(SerchTb.Text != null)
        //    {
        //        serviceSortList = serviceSortList.Where(x => x.Title.ToLower().Contains(SerchTb.Text.ToLower()) || x.Description.ToLower().Contains(SerchTb.Text.ToLower())); //поиск по слову
        //    }

        //}

    }
}
