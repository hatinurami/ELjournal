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
    /// Логика взаимодействия для EditTeacher.xaml
    /// </summary>
    public partial class EditTeacher : Window
    {
        Teachers editTeach;
        public EditTeacher(Teachers teachers)
        {
            InitializeComponent();

            IEnumerable<string> log =
              from Autoriz in DataClass.context.Autoriz
              where Autoriz.idAutoriz == teachers.login
              select Autoriz.login;
            IEnumerable<string> pas =
                from Autoriz in DataClass.context.Autoriz
                where Autoriz.idAutoriz == teachers.login
                select Autoriz.password;
                   
            editTeach = teachers;
            edName.Text = teachers.fName;
            edLName.Text = teachers.lName;
            edPatr.Text = teachers.ptronymic;
            edEmail.Text = teachers.eMail;
            edLog.Text = log.First();
            edPass.Text = pas.First();
           
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void saveCh_Click(object sender, RoutedEventArgs e)
        {
           
            editTeach.fName = edName.Text;
            editTeach.lName = edLName.Text;
            editTeach.ptronymic = edPatr.Text;
            editTeach.eMail = edEmail.Text;
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
