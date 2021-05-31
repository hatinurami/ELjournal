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
using ELjournal.AppData;
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
        public int RowAll { get; set; } = 0;
        public int RowAll2 { get; set; } = 0;
        public int ShowedRows { get; set; } = 0;


        public AdminWin()
        {
            InitializeComponent();
            cb_NumItems.ItemsSource = new List<string>()
            {
                "10",
                "20",
                "30",
                "All"
            };
            cb_NumItems.SelectedIndex = 0;
            Update();

            //  DataContext = this;

        }

        public void Update()
        {
            var datasourse = context.Students.ToList().Where(i => i.available == 1);
            var datasourse2 = context.Teachers.ToList().Where(i => i.available == 1);
            RowAll = datasourse.Count();
            RowAll2 = datasourse2.Count();
            switch (cb_NumItems.SelectedIndex)
            {
                case 0:
                    datasourse = datasourse.Skip(Page * 10).Take(10).ToList();
                    datasourse2 = datasourse2.Skip(Page * 10).Take(10).ToList();
                    btn_Next.IsEnabled = datasourse.Count() >= 10;
                   
                    break;
                case 1:
                    datasourse = datasourse.Skip(Page * 20).Take(20).ToList();
                    datasourse2 = datasourse2.Skip(Page * 20).Take(20).ToList();
                    btn_Next.IsEnabled = datasourse.Count() >= 20;
                    
                    break;
                case 2:
                    datasourse = datasourse.Skip(Page * 30).Take(30).ToList();
                    datasourse2 = datasourse2.Skip(Page * 30).Take(30).ToList();
                    btn_Next.IsEnabled = datasourse.Count() >= 30;
                    
                    break;
                case 3:
                    datasourse = datasourse.ToList();
                    datasourse2 = datasourse2.ToList();
                    btn_Next.IsEnabled = false;
                   
                    break;

                default:
                    break;
            }
            //ShowedRows = datasourse.Count();
            lb_Students.ItemsSource = datasourse;


            //сокращение их до определённого количества
            //datasourse2 = datasourse2.Skip(Page * 10).Take(10).ToList();
            lb_Teachers.ItemsSource = datasourse2;
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
        }

        private void btn_Del_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (rb_Stud.IsChecked == true)
                {
                    var itm = lb_Students.SelectedItem;
                    if (itm == null)
                    {
                        return;
                    }
                    if (MessageBox.Show("Строка пользователя будет удалена из таблицы. Желаете продолжить?", "Удаление", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        int del = (lb_Students.SelectedItem as Students).idStud;

                        Students students = context.Students.Where(i => i.idStud == del).FirstOrDefault();
                        students.available = 0;
                        context.SaveChanges();
                        ListBox_Loaded(sender, e);


                    }
                    else return;

                }
                else if (rb_Prep.IsChecked == true)
                {
                    var itm = lb_Teachers.SelectedItem;
                    if (itm == null)
                    {
                        return;
                    }
                    if (MessageBox.Show("Строка пользователя будет удалена из таблицы. Желаете продолжить?", "Удаление", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        int del = (lb_Teachers.SelectedItem as Teachers).idTeach;

                        Teachers teachers = context.Teachers.Where(i => i.idTeach == del).FirstOrDefault();
                        teachers.available = 0;
                        context.SaveChanges();
                        ListBox_Loaded(sender, e);


                    }
                    else return;
                }

                Update();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Что-то пошло не так!");
            }



        }       
        private void btn_Next_Click(object sender, RoutedEventArgs e)
        {
            btn_Back.IsEnabled = true;
            Page++;
            Update();
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            if (Page > 0)
            {
                Page--;
                Update();
            }
            else if(Page == 0)
            {
                btn_Back.IsEnabled = false;
            }
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

        private void cb_NumItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Page = 0;
            Update();
        }

        private void lb_Students_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lb_Students.SelectedItem is Students students)
            {
                EditStudent edit = new EditStudent(students);
                edit.ShowDialog();
            }

        }

        private void lb_Teachers_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lb_Teachers.SelectedItem is Teachers teachers)
            {
              
                    EditTeacher edit = new EditTeacher(teachers);
                    edit.ShowDialog();
                
            }
        }
    }
}
