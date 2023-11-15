using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PracticaKornilovaMarushkina
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static bool isHeadDepartment;
        public static bool isEngineer;
        public static bool isTeacher;
        public static Ych_PR_KMEntities db = new Ych_PR_KMEntities();


    }
}
