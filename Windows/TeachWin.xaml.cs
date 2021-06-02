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
        Journal edJ;
        public int RowAll { get; set; }
        public int Page { get; set; }

        public TeachWin()
        {
            InitializeComponent();
            var subN = context.Subjects.Where(i => i.idTeach == userTeach.idTeach).Select(c => c.subjName).First();
            string prepN = $"{userTeach.lName} {userTeach.ptronymic}: {subN}";
            TeachNameLab.Text = prepN;
            cb_NumItems.ItemsSource = new List<string>()
            {
                "10",
                "20",
                "30",
                "All"
            };
            cb_NumItems.SelectedIndex = 0;

            cbMark.ItemsSource = new List<string>()
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                "Н"
            };
            Update();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        public void Update()
        {
            var subN = context.Subjects.Where(i => i.idTeach == userTeach.idTeach).FirstOrDefault();
            var datasourse = context.Journal.Where(i => i.idSubj == subN.idSubj ).ToList();
            RowAll = datasourse.Count();

            var jrnl = context.Journal.Where(i => i.idSubj == subN.idSubj).FirstOrDefault();
            var grquery = context.Group.Where(d => d.idGroup == jrnl.idGroup).Select(i => i.nameGroup).ToList();
            grquery.Insert(0, "Выберите группу");
            cbGroup.ItemsSource = grquery;
            cbGroup.SelectedIndex = 0;

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
            lbJournal.ItemsSource = datasourse;
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
        private void ok_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (cbMark.SelectedIndex != -1)
                {
                    edJ.mark = cbMark.SelectedIndex +1;
                }
                edJ.comment = txtComm.Text;
                edJ.dateM = DateTime.Today;
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
           // Update();
        }

        private void ResetSearch(object sende, RoutedEventArgs e)
        {
            FamSearch1.Text = "";
            ImySearch1.Text = "";
            

            lbJournal.ItemsSource = context.Journal.ToList();
        }
        private void Search(object sender, RoutedEventArgs e)
        {
            var subN = context.Subjects.Where(i => i.idTeach == userTeach.idTeach).FirstOrDefault();
            var datasourse = context.Journal.Where(i => i.idSubj == subN.idSubj).ToList();
            var edit = context.Students.Where(i => i.idStud == datasourse.Select(c => c.idStudent).First()).FirstOrDefault();
            if (FamSearch1.Text.Length == 0 && ImySearch1.Text.Length == 0
               )
            {
                lbJournal.ItemsSource = datasourse.ToList();
                return;
            }

            var res = datasourse.Where(i => 
                                 edit.fName.Contains(ImySearch1.Text) &&
                                 edit.lName.Contains(FamSearch1.Text)
                                 ).ToList();
            if (res.Count() != 0)
                lbJournal.ItemsSource = res;
            else
                MessageBox.Show("Внимание!", " Не найдено!",
                    MessageBoxButton.OK, MessageBoxImage.Warning);

        }
    }
}
