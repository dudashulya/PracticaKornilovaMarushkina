﻿using System;
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
using PracticaKornilovaMarushkina.DataBase;
using PracticaKornilovaMarushkina;

namespace PracticaKornilovaMarushkina.Pages
{
    /// <summary>
    /// Логика взаимодействия для SelectionPage.xaml
    /// </summary>
    public partial class SelectionPage : Page
    {
        public SelectionPage()
        {
            InitializeComponent();
        }

        private void DepartB_Click(object sender, RoutedEventArgs e)
        {
            Navigation.NextPage(new PageComponents("Список услуг", new DepartmentPage()));
        }

        private void DisciplineB_Click(object sender, RoutedEventArgs e)
        {
           
            Navigation.NextPage(new PageComponents("Список услуг", new PageZAV()));
        }
    }
}
