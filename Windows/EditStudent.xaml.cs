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

            IEnumerable<string> gr =
               from Group in context.Group
               where Group.idGroup == students.idGroup
               select Group.nameGroup;

            IEnumerable<string> log =
              from Autoriz in context.Autoriz
              where Autoriz.idAutoriz == students.login
              select Autoriz.login;

            IEnumerable<string> pass =
             from Autoriz in context.Autoriz
             where Autoriz.idAutoriz == students.login
             select Autoriz.password;


            var grquery = context.Group.Select(i => i.nameGroup).ToList();
            grquery.Insert(0, "Выберите группу");
            edGroup.ItemsSource = grquery;

            editStud = students;
            edName.Text = students.fName;
            edLName.Text = students.lName;
            edPatr.Text = students.patronymic;
            edEmail.Text = students.eMail;
            edLog.Text = log.First();
            edPass.Text = pass.First();
            edGroup.Text = gr.First();

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void saveCh_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (Valid.Validation.ValidateName(edName.Text) == true && Valid.Validation.ValidateName(edLName.Text) == true && Valid.Validation.ValidateName(edPatr.Text))
                {
                    if (edGroup.SelectedIndex != -1)
                    {
                        editStud.idGroup = edGroup.SelectedIndex;
                    }

                    var aut = context.Autoriz.Where(i => i.idAutoriz == editStud.login).FirstOrDefault();
                    editStud.fName = edName.Text;
                    editStud.lName = edLName.Text;
                    editStud.patronymic = edPatr.Text;
                    editStud.eMail = edEmail.Text;
                    aut.login = edLog.Text;
                    aut.password = edPass.Text;
                    context.SaveChanges();

                    var mes = MessageBox.Show("Данные обновлены", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                    if (mes == MessageBoxResult.OK)
                    {
                        Exit_Click(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Введите корректные данные!");
                }
            }
            catch (Exception mes)
            {
                MessageBox.Show(mes.Message);
            }
        }
    }
}
