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
    /// Логика взаимодействия для StudentWin.xaml
    /// </summary>
    public partial class StudentWin : Window
    {
        public int RowAll { get; set; }
        public int Page { get; set; }

        public StudentWin()
        {
            InitializeComponent();
            DataContext = this;

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
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var subN = context.Group.Where(i => i.idGroup == userStud.idGroup).Select(c => c.nameGroup).First();
            string prepN = $"{userStud.lName} {userStud.fName} {subN}";
            StudNameLab.Text = prepN;
            Update();
        }
        public void Update()
        {
            
            var datasourse = context.Journal.Where(i => i.idStudent == userStud.idStud).ToList();

            RowAll = datasourse.Count();

            switch (cb_NumItems.SelectedIndex)
            {
                case 0:
                    datasourse = datasourse.Skip(Page * 10).Take(10).ToList();
                    btn_Next.IsEnabled = datasourse.Count() >= 10;
                    break;
                case 1:
                    datasourse = datasourse.Skip(Page * 20).Take(20).ToList();
                    btn_Next.IsEnabled = datasourse.Count() >= 20;
                    break;
                case 2:
                    datasourse = datasourse.Skip(Page * 30).Take(30).ToList();
                    btn_Next.IsEnabled = datasourse.Count() >= 30;
                    break;
                case 3:
                    datasourse = datasourse.ToList();
                    btn_Next.IsEnabled = false;
                    break;
                default:
                    break;
            }
            lbJournalSt.ItemsSource = datasourse;
            btn_Back.IsEnabled = Page != 0;

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
        private void cb_NumItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Page = 0;
            Update();
        }



        public void LoadList(List<Journal> journals)
        {
            lbJournalSt.Items.Clear();
            foreach (var item in journals)
            {
                lbJournalSt.Items.Add(item);
            }
        }
        private void ResetSearch(object sende, RoutedEventArgs e)
        {
            Subj1.Text = "";
           
            
            var et = context.Journal.Where(i => i.idStudent == userStud.idStud).ToList();

            List<Journal> journals = et;
            LoadList(journals);

        }
        private void Search(object sender, RoutedEventArgs e)
        {
        //    try
        //    {
        //        var sub = context.Subjects.Where(i => i.idSubj == userTeach.idSubj).FirstOrDefault();
        //        var et = context.Group.Where(t => t.nameGroup == cbGroup.SelectedItem).Select(r => r.idGroup).FirstOrDefault();

        //        List<Journal> journals = context.Journal.Where(i => i.idSubj == sub.idSubj && i.idGroup == et).ToList();

        //        if (FamSearch1.Text != "")
        //        {
        //            int students = context.Students.Where(i => i.lName == FamSearch1.Text).Select(w => w.idStud).FirstOrDefault();
        //            journals = journals.FindAll(i => i.idStudent == students);
        //        }

        //        if (ImySearch1.Text != "")
        //        {
        //            int students = context.Students.Where(i => i.fName == ImySearch1.Text).Select(w => w.idStud).FirstOrDefault();
        //            journals = journals.FindAll(i => i.idStudent == students);
        //        }
        //        if (journals.Count == 0)
        //        {
        //            MessageBox.Show("Не найдено!", "Внимание!",
        //               MessageBoxButton.OK, MessageBoxImage.Warning);
        //        }
        //        LoadList(journals);

        //    }
        //    catch
        //    {
        //        MessageBox.Show("Извините, но оно пока что не работает", "УПС", MessageBoxButton.OK, MessageBoxImage.Error);
        //    }

        }

    }
}
