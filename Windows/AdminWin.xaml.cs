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
                    if (rb_Prep.IsChecked == true)
                    {
                        btn_Next.IsEnabled = datasourse2.Count() >= 10;

                    }
                    else if (rb_Stud.IsChecked == true)
                    {
                        btn_Next.IsEnabled = datasourse.Count() >= 10;

                    }
                    break;
                case 1:
                    datasourse = datasourse.Skip(Page * 20).Take(20).ToList();
                    datasourse2 = datasourse2.Skip(Page * 20).Take(20).ToList();
                    if (rb_Prep.IsChecked == true)
                    {
                        btn_Next.IsEnabled = datasourse2.Count() >= 20;

                    }
                    else if (rb_Stud.IsChecked == true)
                    {
                        btn_Next.IsEnabled = datasourse.Count() >= 20;

                    }

                    break;
                case 2:
                    datasourse = datasourse.Skip(Page * 30).Take(30).ToList();
                    datasourse2 = datasourse2.Skip(Page * 30).Take(30).ToList();
                    if (rb_Prep.IsChecked == true)
                    {
                        btn_Next.IsEnabled = datasourse2.Count() >= 30;

                    }
                    else if (rb_Stud.IsChecked == true)
                    {
                        btn_Next.IsEnabled = datasourse.Count() >= 30;

                    }

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
            lb_Teachers.ItemsSource = datasourse2;
            btn_Back.IsEnabled = Page != 0;

            

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

            GR_BOX.Visibility = Visibility.Visible;
            GR_BOX2.Visibility = Visibility.Collapsed;

            Page = 0;
            Update();
        }

        private void rb_Prep_Click(object sender, RoutedEventArgs e)
        {
            lb_Teachers.Visibility = Visibility.Visible;
            lb_Students.Visibility = Visibility.Collapsed;

            GR_BOX2.Visibility = Visibility.Visible;
            GR_BOX.Visibility = Visibility.Collapsed;

            Page = 0;
            Update();
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
                Update();
            }

        }

        private void lb_Teachers_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lb_Teachers.SelectedItem is Teachers teachers)
            {
                EditTeacher edit = new EditTeacher(teachers);
                edit.ShowDialog();
                Update();
            }
        }

        private void ResetSearch(object sende, RoutedEventArgs e)
        {
            FamSearch1.Text = "";
            ImySearch1.Text = "";
            
            PatrSearch1.Text = "";

            lb_Students.ItemsSource = context.Students.ToList();
        }
        private void Search(object sender, RoutedEventArgs e)
        {
            if (rb_Stud.IsChecked == true)
            {
                var tabb = context.Students.ToList().Where(i => i.available == 1);
                if (FamSearch10.Text.Length == 0 && ImySearch10.Text.Length == 0 &&
                    PatrSearch10.Text.Length == 0)
                {
                    lb_Students.ItemsSource = tabb.ToList();
                    return;
                }

                var res = tabb.Where(i => i.lName.Contains(FamSearch10.Text) &&
                                     i.fName.Contains(ImySearch10.Text) &&
                                     i.patronymic.Contains(PatrSearch10.Text)
                                     ).ToList();
                if (res.Count() != 0)
                    lb_Students.ItemsSource = res;
                else
                    MessageBox.Show("Внимание!", " Не найдено!",
                        MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            else if (rb_Prep.IsChecked == true)
            {
                var tabb = context.Teachers.ToList().Where(i => i.available == 1);
                if (FamSearch10.Text.Length == 0 && 
                    ImySearch10.Text.Length == 0 &&
                    PatrSearch10.Text.Length == 0)
                {
                    lb_Teachers.ItemsSource = tabb.ToList();
                    return;
                }


                var res = tabb.Where(i => i.lName.Contains(FamSearch10.Text) &&
                                     i.fName.Contains(ImySearch10.Text) &&
                                     i.ptronymic.Contains(PatrSearch10.Text)
                                     ).ToList();
                if (res.Count() != 0)
                    lb_Teachers.ItemsSource = res;
                else
                    MessageBox.Show("Внимание!", " Не найдено!",
                        MessageBoxButton.OK, MessageBoxImage.Warning);

            }
        }
    }
}
