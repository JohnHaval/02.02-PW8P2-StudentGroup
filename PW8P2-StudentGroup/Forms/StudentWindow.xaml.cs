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

namespace PW8P2_StudentGroup
{
    /// <summary>
    /// Логика взаимодействия для AddStudent.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        public StudentWindow()
        {
            InitializeComponent();
        }
        public StudentWindow(Student student)
        {
            InitializeComponent();
            CurrentStudent = student;
            Title = "Изменить студента";
            Confirm.Content = "Изменить";
            TransferDataToGUI();
        }
        private void TransferDataToGUI()
        {
            SecondName.Text = CurrentStudent.SecondName;
            BornDate.SelectedDate = CurrentStudent.BornDate;
            EnterYear.Text = CurrentStudent.EnterYear.ToString();
            Course.Text = CurrentStudent.Course.ToString();
            Group.Text = CurrentStudent.Group.ToString();
        }
        Student CurrentStudent;
        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var student = new Student()
                {
                    SecondName = SecondName.Text,
                    BornDate = (DateTime)BornDate.SelectedDate,
                    EnterYear = Convert.ToInt32(EnterYear.Text),
                    Course = Convert.ToInt32(Course.Text),
                    Group = Group.Text
                };
                if (CurrentStudent == null) MainWindow.Students.Add(student);
                else
                {
                    CurrentStudent.SecondName = student.SecondName;
                    CurrentStudent.BornDate = student.BornDate;
                    CurrentStudent.EnterYear = student.EnterYear;
                    CurrentStudent.Course = student.Course;
                    CurrentStudent.Group = student.Group;
                }
                DialogResult = true;
                Close();
            }
            catch
            {
                MessageBox.Show("Неверно введено значение одного из полей!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
