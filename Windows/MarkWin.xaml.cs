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
    /// Логика взаимодействия для MarkWin.xaml
    /// </summary>
    public partial class MarkWin : Window
    {
        List<string> stdN = new List<string>();
        List<string> stdS = new List<string>();
        public MarkWin()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbMark.ItemsSource = new List<string>()
            {
                "1",
                "2",
                "3",
                "4",
                "5"
                
            };

            var jrnl = context.Journal.Where(i => i.idTeach == userTeach.idTeach).Select(c => c.idGroup).ToList();
            List<string> grItem = new List<string>();
            foreach (var item in jrnl)
            {
                grItem.Add(context.Group.Where(i => i.idGroup == item).Select(i => i.nameGroup).FirstOrDefault());
            }
            edGroup.ItemsSource = grItem.Distinct();


           
        
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void edGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            spStud.Visibility = Visibility.Visible;
            var grn = context.Group.Where(i => i.nameGroup == edGroup.SelectedItem).Select(t => t.idGroup).FirstOrDefault();
            stdN = context.Students.Where(i => i.idGroup == grn).Select(t => t.fName).ToList();
            stdS = context.Students.Where(i => i.idGroup == grn).Select(t => t.lName).ToList();
            List<string> fio = new List<string>();
            for (int i = 0; i < stdN.Count(); i++)
            {
                 fio.Add(stdN[i] + " " + stdS[i]);
            }
            cbStud.ItemsSource = fio;

            spMrk.Visibility = Visibility.Collapsed;
            cbMark.SelectedIndex = -1;
            tbx.Text = string.Empty;
        }

        private void cbStud_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            spMrk.Visibility = Visibility.Visible;
        }

        private void cbMark_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            saveCh.IsEnabled = true;
        }
        private void saveCh_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            string stIndex = stdN[cbStud.SelectedIndex];
            int idst = context.Students.Where(i => i.fName == stIndex).Select(r => r.idStud).FirstOrDefault();
            int idgr = context.Students.Where(i => i.fName == stIndex).Select(r => r.idGroup).FirstOrDefault();
            Journal fr = new Journal();

            fr.idStudent = idst;
                fr.mark = Convert.ToInt32(cbMark.SelectedItem);
                fr.idSubj = userTeach.idSubj;
                fr.dateM = DateTime.Now;
                fr.idTeach = userTeach.idTeach;
                fr.comment = tbx.Text;
                fr.idGroup = idgr;

            context.Journal.Add(fr);
            context.SaveChanges();
            MessageBox.Show("Данные сохранены");
            Close();

            }
            catch 
            {

                MessageBox.Show("Проверьте корректность ввдённых данных");
            }
        }

    }
}
