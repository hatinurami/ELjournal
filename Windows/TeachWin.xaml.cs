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
    /// Логика взаимодействия для TeachWin.xaml
    /// </summary>
    public partial class TeachWin : Window
    {
        public static Journal edJ;
        public int RowAll { get; set; }
        public int Page { get; set; }

        public TeachWin()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var sub = context.Subjects.Where(i => i.idSubj == userTeach.idSubj).Select(c => c.subjName).First();
            string prepN = $"{userTeach.fName} {userTeach.ptronymic}: {sub}";
            TeachNameLab.Text = prepN;
            cb_NumItems.ItemsSource = new List<string>()
            {
                "10",
                "20",
                "30",
                "All"
            };
            cb_NumItems.SelectedIndex = 0;
            cbGroup.SelectedIndex = 0;
            cbMark.ItemsSource = new List<string>()
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                
            };
            Update();

        }

        public void Update()
        {
            var jrnl = context.Journal.Where(i => i.idTeach == userTeach.idTeach).Select(c => c.idGroup).ToList();
            List<string> grItem = new List<string>();
            foreach (var item in jrnl)
            {
                grItem.Add(context.Group.Where(i => i.idGroup == item).Select(i => i.nameGroup).FirstOrDefault());                
            }
           
            cbGroup.ItemsSource = grItem.Distinct();

            var sub = context.Subjects.Where(i => i.idSubj == userTeach.idSubj).FirstOrDefault();
            var et = context.Group.Where(t => t.nameGroup == cbGroup.SelectedItem).Select(e => e.idGroup).FirstOrDefault();
            var datasourse = context.Journal.Where(i => i.idSubj == sub.idSubj && i.idGroup == et).ToList();
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
            LoadList(datasourse);
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

        private void lbJournal_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lbJournal.SelectedItem is Journal journal)
            {
                edJ = journal;
                var edit = context.Students.Where(i => i.idStud == journal.idStudent).FirstOrDefault();
                tbName.Text = edit.fName;
                tbLName.Text = edit.lName;
                WPnl.Visibility = Visibility.Visible;
                
               
            }

        }

        public void LoadList(List<Journal> journals)
        {
            lbJournal.Items.Clear();
            foreach (var item in journals)
            {
                lbJournal.Items.Add(item);
            }
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (cbMark.SelectedIndex != -1)
                {
                    edJ.mark = cbMark.SelectedIndex +1;
                }
                edJ.comment = txtComm.Text;               
                context.SaveChanges();
                var mes = MessageBox.Show("Данные обновлены", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                if (mes == MessageBoxResult.OK)
                {
                    WPnl.Visibility = Visibility.Hidden;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            Update();
        }

        private void lbJournal_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void cb_NumItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Page = 0;
            Update();
        }

        private void cbGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            Page = 0;
            Update();

        }

        private void ResetSearch(object sende, RoutedEventArgs e)
        {
            FamSearch1.Text = "";
            ImySearch1.Text = "";
            var sub = context.Subjects.Where(i => i.idSubj == userTeach.idSubj).FirstOrDefault();
            var et = context.Group.Where(t => t.nameGroup == cbGroup.SelectedItem).Select(r => r.idGroup).FirstOrDefault();

            List<Journal> journals = context.Journal.Where(i => i.idSubj == sub.idSubj && i.idGroup == et).ToList();
            LoadList(journals);

        }
        private void Search(object sender, RoutedEventArgs e)
        {
            try
            {
                var sub = context.Subjects.Where(i => i.idSubj == userTeach.idSubj).FirstOrDefault();
                var et = context.Group.Where(t => t.nameGroup == cbGroup.SelectedItem).Select(r => r.idGroup).FirstOrDefault();

                List<Journal> journals = context.Journal.Where(i => i.idSubj == sub.idSubj && i.idGroup == et).ToList();

                if (FamSearch1.Text != "")
                {
                    int students = context.Students.Where(i => i.lName == FamSearch1.Text).Select(w => w.idStud).FirstOrDefault();
                    journals = journals.FindAll(i => i.idStudent == students);
                }
                
                if (ImySearch1.Text != "")
                {
                    int students = context.Students.Where(i => i.fName == ImySearch1.Text).Select(w => w.idStud).FirstOrDefault();
                    journals = journals.FindAll(i => i.idStudent == students);
                }
                if (journals.Count == 0)
                {
                    MessageBox.Show("Не найдено!",  "Внимание!", 
                       MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                LoadList(journals);

            }
            catch 
            {
                MessageBox.Show("Извините, но оно пока что не работает", "УПС", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void AddMark_Click(object sender, RoutedEventArgs e)
        {
            MarkWin mark = new MarkWin();
            mark.ShowDialog();
            ResetSearch(sender, e);
        }
    }
}
