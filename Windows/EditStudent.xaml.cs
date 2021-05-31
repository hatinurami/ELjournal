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
    /// Логика взаимодействия для EditStudent.xaml
    /// </summary>
    public partial class EditStudent : Window
    {
        Students editStud;
        public EditStudent(Students students)
        {
            InitializeComponent();
            IEnumerable<string> log =
                from Autoriz in DataClass.context.Autoriz
                where Autoriz.idAutoriz == students.login
                select Autoriz.login;
            IEnumerable<string> pas =
                from Autoriz in DataClass.context.Autoriz
                where Autoriz.idAutoriz == students.login
                select Autoriz.password;
            IEnumerable<string> gr =
               from Group in DataClass.context.Group
               where Group.idGroup == students.idGroup
               select Group.nameGroup;

            var grquery = context.Group.Select(i => i.nameGroup).ToList();
            grquery.Insert(0, "Выберите группу");
            edGroup.ItemsSource = grquery;

            editStud = students;
            edName.Text = students.fName;
            edLName.Text = students.lName;
            edPatr.Text = students.patronymic;
            edEmail.Text = students.eMail;
            edLog.Text = log.First();
            edPass.Text = pas.First();
            edGroup.Text = gr.First();

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void saveCh_Click(object sender, RoutedEventArgs e)
        {
            if (edGroup.SelectedIndex != -1)
            {
                editStud.idGroup = edGroup.SelectedIndex;
            }
            editStud.fName = edName.Text;
            editStud.lName = edLName.Text;
            editStud.patronymic = edPatr.Text;
            editStud.eMail = edEmail.Text;
            //editStud.login =
            
            try
            {
                context.SaveChanges();
                MessageBox.Show("Данные обновлены");
            }
            catch (Exception mes)
            {
                MessageBox.Show(mes.Message);
                
            }
        }
    }
}
