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
using System.Windows.Shapes;
using static ELjournal.AppData.DataClass;

namespace ELjournal.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdminWin.xaml
    /// </summary>
    public partial class AdminWin : Window
    {
        //номер страницы
        public int Page { get; set; } = 0;

        public AdminWin()
        {
            InitializeComponent();
          
            Update();
            //  DataContext = this;

        }

        public void Update()
        {

               var datasourse = context.Students.ToList();
               //сокращение их до определённого количества
               datasourse = datasourse.Skip(Page * 10).Take(10).ToList();
               lb_Students.ItemsSource = datasourse;
               
            
            
                           
               var datasourse2 = context.Teachers.ToList();
               //сокращение их до определённого количества
               datasourse2 = datasourse2.Skip(Page * 10).Take(10).ToList();
               lb_Teachers.ItemsSource = datasourse2;
            
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Del_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Next_Click(object sender, RoutedEventArgs e)
        {
            Page++;
            Update();
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            Page--;
            Update();
        }

        private void ListBox_Loaded(object sender, RoutedEventArgs e)
        {

            if (rb_Prep.IsChecked == true)
            {
                lb_Teachers.Visibility = Visibility.Visible;
                lb_Students.Visibility = Visibility.Collapsed;
               
            }
            else if (rb_Stud.IsChecked == true)
            {
                lb_Teachers.Visibility = Visibility.Collapsed;
                lb_Students.Visibility = Visibility.Visible;
               
            }
        }

        private void rb_Stud_Click(object sender, RoutedEventArgs e)
        {
            lb_Teachers.Visibility = Visibility.Collapsed;
            lb_Students.Visibility = Visibility.Visible;
        }

        private void rb_Prep_Click(object sender, RoutedEventArgs e)
        {
            lb_Teachers.Visibility = Visibility.Visible;
            lb_Students.Visibility = Visibility.Collapsed;
        }
    }
}
