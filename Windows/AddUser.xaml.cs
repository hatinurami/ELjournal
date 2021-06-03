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
    /// Логика взаимодействия для AddUser.xaml
    /// </summary>
    public partial class AddUser : Window
    {


        public AddUser()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var gr = context.Group;
            cbx_group.ItemsSource = gr.ToList();

            var disc = context.Subjects;
            cbx_subj.ItemsSource = disc.ToList();

        }

        private void btn_addStud_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (rbAddMode_Stud.IsChecked == true)
                {

                    if (
                        txtName.Text == string.Empty ||
                        txtlName.Text == string.Empty ||
                        txtPatr.Text == string.Empty ||
                        cbx_group.SelectedItem == null ||
                        txt_eMail.Text == string.Empty ||
                        txt_log.Text == string.Empty ||
                        txt_pass.Text == string.Empty)
                    {
                        MessageBox.Show("Заполните все поля!");
                    }
                    else
                    {
                        if (Valid.Validation.ValidateName(txtName.Text) == true && Valid.Validation.ValidateName(txtlName.Text) == true && Valid.Validation.ValidateName(txtPatr.Text))
                        {
                        Autoriz autoriz = context.Autoriz.Add(new Autoriz
                        {
                            login = txt_log.Text,
                            password = txt_pass.Text,
                            uRole = 3
                        }
                            );


                        Students students = context.Students.Add(new Students
                        {
                            fName = txtName.Text,
                            lName = txtlName.Text,
                            patronymic = txtPatr.Text,
                            gender = rb_genM.IsChecked == true ? 1 : 2,
                            idGroup = cbx_group.SelectedIndex + 1,
                            eMail = txt_eMail.Text,
                            available = 1,
                            login = autoriz.idAutoriz

                        }
                            ); ;

                        context.SaveChanges();
                        MessageBox.Show("Пользователь добавлен!");

                        }
                        else
                        {
                            MessageBox.Show("Введите корректные данные!");
                        }


                    }
                }
                else if (rbAddMode_Prep.IsChecked == true)
                {
                    if (Valid.Validation.ValidateName(txtName.Text) == true && Valid.Validation.ValidateName(txtlName.Text) == true && Valid.Validation.ValidateName(txtPatr.Text))
                    {
                        if (
                       txtName.Text == string.Empty ||
                       txtlName.Text == string.Empty ||
                       txtPatr.Text == string.Empty ||
                       cbx_subj.SelectedItem == null ||
                       txt_eMail.Text == string.Empty ||
                       txt_log.Text == string.Empty ||
                       txt_pass.Text == string.Empty)
                        {
                            MessageBox.Show("Заполните все поля!");
                        }
                        else
                        {
                            Autoriz autoriz = context.Autoriz.Add(new Autoriz
                            {
                                login = txt_log.Text,
                                password = txt_pass.Text,
                                uRole = 2
                            }
                            );



                            Teachers teachers = context.Teachers.Add(new Teachers
                            {
                                fName = txtName.Text,
                                lName = txtlName.Text,
                                ptronymic = txtPatr.Text,
                                gender = rb_genM.IsChecked == true ? 1 : 2,
                                eMail = txt_eMail.Text,
                                login = autoriz.idAutoriz,
                                available = 1,
                                idSubj = cbx_subj.SelectedIndex + 1


                            }
                                );
                            context.SaveChanges();
                            MessageBox.Show("Пользователь добавлен!");
                        }
                        

                    }
                    else
                        MessageBox.Show("Введите корректные данные!");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка при сохранении.");               
            }
        }


        private void addMode_Loaded(object sender, RoutedEventArgs e)
        {
            if (rbAddMode_Prep.IsChecked == true)
            {
                cbx_group.Visibility = Visibility.Hidden;
                tbl_group.Visibility = Visibility.Hidden;

                cbx_subj.Visibility = Visibility.Visible;
                tbl_subj.Visibility = Visibility.Visible;

            }
            else if (rbAddMode_Stud.IsChecked == true)
            {
                cbx_group.Visibility = Visibility.Visible;
                tbl_group.Visibility = Visibility.Visible;


                cbx_subj.Visibility = Visibility.Hidden;
                tbl_subj.Visibility = Visibility.Hidden;
            }

        }



        private void rbAddMode_Prep_Click(object sender, RoutedEventArgs e)
        {
            cbx_group.Visibility = Visibility.Hidden;
            tbl_group.Visibility = Visibility.Hidden;

            cbx_subj.Visibility = Visibility.Visible;
            tbl_subj.Visibility = Visibility.Visible;
            
        }

        private void rbAddMode_Stud_Click(object sender, RoutedEventArgs e)
        {
            cbx_group.Visibility = Visibility.Visible;
            tbl_group.Visibility = Visibility.Visible;


            cbx_subj.Visibility = Visibility.Hidden;
            tbl_subj.Visibility = Visibility.Hidden;
        }
    }
}
