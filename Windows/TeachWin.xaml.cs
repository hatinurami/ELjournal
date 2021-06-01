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
        public int RowAll { get; set; }
        public int Page { get; set; }

        public TeachWin()
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
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var grquery = context.Group.Select(i => i.nameGroup).ToList();
            grquery.Insert(0, "Выберите группу");
            cbGroup.ItemsSource = grquery;
            cbGroup.SelectedIndex = 0;

        }

        public void Update()
        {
            var datasourse = context.Journal.ToList();
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
            var gr = context.Group.Where(c => c.nameGroup == cbGroup.SelectedItem.ToString()).Select(i => i.idGroup).FirstOrDefault();
            var stud = context.Students.Where(i => i.idGroup == gr).ToList();
            Update();

        }
    }
}
