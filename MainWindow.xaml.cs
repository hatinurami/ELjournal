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
using System.Windows.Navigation;
using System.Windows.Shapes;
using static ELjournal.AppData.DataClass;

using ELjournal.Windows;

namespace ELjournal
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Enter_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                var autoriz = context.Autoriz.ToList().Where(i => i.login == txt_Login.Text && i.password == psb_Password.Password).FirstOrDefault();
                if (autoriz != null)
                {
                    var user = context.Teachers.Where(i => i.login == autoriz.idAutoriz ).FirstOrDefault();
                    var user2 = context.Students.Where(i => i.login == autoriz.idAutoriz).FirstOrDefault();
                    if (user != null && user2 == null && autoriz.uRole == 2 && user.available == 1)
                    {
                        userTeach = user;                       
                        Hide();
                        TeachWin teach = new TeachWin();
                        teach.ShowDialog();
                        Show();

                    }
                    else if (user == null && user2 != null && autoriz.uRole == 3 && user2.available == 1)
                    {
                        StudentWin student = new StudentWin();
                        userStud = user2;          
                        Hide();
                        student.ShowDialog();
                        Show();
                    }
                    else if (user != null && user2 == null && autoriz.uRole == 1)
                    {
                        AdminWin admin = new AdminWin();
                        userTeach = user;
                        Hide();
                        admin.ShowDialog();
                        Show();

                    }
                    txt_Login.Text = string.Empty;
                    psb_Password.Password = string.Empty;
                }
                else MessageBox.Show("Пользователь не найден");
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так!");
                
            }

        }


    }


}

