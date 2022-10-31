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
    /// Логика взаимодействия для SubjectWindow.xaml
    /// </summary>
    public partial class SubjectWindow : Window
    {
        public SubjectWindow(int studentID)
        {
            InitializeComponent();
            CurrentStudentID = studentID;
        }
        public SubjectWindow(Subject subject)
        {
            InitializeComponent();
            Subject = subject;
            Title = "Изменить предмет";
            Confirm.Content = "Изменить";
            TransferDataToGUI();
        }
        private void TransferDataToGUI()
        {
            SubjectName.Text = Subject.Name;
            Year.Text = Subject.Year.ToString();
            Mark.Text = Subject.Mark.ToString();
        }
        int CurrentStudentID = -1;
        Subject Subject;

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var subject = new Subject()
                {
                    StudentID = CurrentStudentID,
                    Name = SubjectName.Text,
                    Year = Convert.ToInt32(Year.Text),
                    Mark = Convert.ToInt32(Mark.Text)
                };
                if (CurrentStudentID != -1) MainWindow.Students.Find(student => student.StudentID == CurrentStudentID).AddSubject(subject);
                else
                {
                    MainWindow.Students.Find(student => student.StudentID == Subject.StudentID).Subjects.Remove(Subject);
                    subject.StudentID = Subject.StudentID;
                    MainWindow.Students.Find(student => student.StudentID == Subject.StudentID).AddSubject(subject);
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
