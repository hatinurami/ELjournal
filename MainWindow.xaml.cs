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
using static ELjournal.AppData.DataClass;
using ELjournal.Windows;

namespace ELjournal
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Enter_Click(object sender, RoutedEventArgs e)
        {
            var user = context.Autoriz.ToList().Where(i => i.login == txt_Login.Text && i.password == psb_Password.Password).FirstOrDefault();
            if (user != null)
            {
               // userStud = context.Autoriz.Where(i => i.idAutoriz == (context.Students.Select(c => c.login)))
            }
            AdminWin adminWin = new AdminWin();
            Close();
            adminWin.ShowDialog();

        }

       
    }
}
