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
            StudentID = studentID;
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
            Name.Text = Subject.Name;
            Year.Text = Subject.Year.ToString();
            Mark.Text = Subject.Mark.ToString();
        }
        int StudentID = -1;
        Subject Subject;

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var subject = new Subject()
                {
                    Name = Name.Text,
                    Year = Convert.ToInt32(Year.Text),
                    Mark = Convert.ToInt32(Mark.Text)
                };
                if (StudentID != -1) MainWindow.Students.Find(student => student.StudentID == StudentID).AddSubject(subject);
                else
                {
                    Subject.Name = subject.Name;
                    Subject.Year = subject.Year;
                    Subject.Mark = subject.Mark;
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
