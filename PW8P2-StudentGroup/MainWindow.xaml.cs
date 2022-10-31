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

namespace PW8P2_StudentGroup
{
    /// <summary>
    /// Hapro Bishop (Sergey Lopatkin) 
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static List<Student> Students = new List<Student>();
        private void StudentsMainInfo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                YearsAndMarks.ItemsSource = null;
                if (e == null)
                {
                    if (YearsAndMarks == null)
                    {
                        CurrentSturdentID = -1;
                    }
                    return;
                }
                var student = (Student)e.AddedItems[0];
                CurrentSturdentID = student.StudentID;
                YearsAndMarks.ItemsSource = student.Subjects;
            }
            catch { }
        }
        public int CurrentSturdentID = -1;
        private void AutoFill_Click(object sender, RoutedEventArgs e)
        {            
            StudentsMainInfo.ItemsSource = AutoFillWithoutGUI.AutoFillList();
        }        
        private void Sort_Click(object sender, RoutedEventArgs e)
        {
            var win = new SortWindow()
            {
                Owner = this
            };
            if (win.ShowDialog() == true) StudentsMainInfo.Items.Refresh();
        }

        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            Students.Clear();
            Student.ResetIDCounter();
            StudentsMainInfo.ItemsSource = null;
            YearsAndMarks.Items.Clear();
        }
        public void RefreshAll()
        {
            StudentsMainInfo.Items.Refresh();
            YearsAndMarks.Items.Refresh();
        }
        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            var win = new StudentWindow()
            {
                Owner = this
            };
            if (win.ShowDialog() == true)
            {
                if (StudentsMainInfo.ItemsSource != null) RefreshAll();
                else StudentsMainInfo.ItemsSource = Students;
            }
        }

        private void AddSubject_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (StudentsMainInfo != null)
                {
                    if (CurrentSturdentID == -1 || StudentsMainInfo.Items.Count == 0) throw new Exception();
                    var win = new SubjectWindow(CurrentSturdentID)
                    {
                        Owner = this
                    };
                    if (win.ShowDialog() == true) RefreshAll();
                }
                else throw new Exception();
            }
            catch
            {
                MessageBox.Show("Перед добавлением предмета, необходимо выбрать студента!", "Добавление предмета", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EditStudent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (StudentsMainInfo != null)
                {
                    if (StudentsMainInfo.SelectedItem == null) throw new Exception();
                    var win = new StudentWindow((Student)StudentsMainInfo.SelectedItem)
                    {
                        Owner = this
                    };
                    if (win.ShowDialog() == true) RefreshAll();
                }
                else throw new Exception();
            }
            catch
            {
                MessageBox.Show("Перед изменением студента, необходимо его выбрать!", "Изменение студента", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EditSubject_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (YearsAndMarks != null)
                {
                    if (YearsAndMarks.SelectedItem == null) throw new Exception();
                    var win = new SubjectWindow((Subject)YearsAndMarks.SelectedItem)
                    {
                        Owner = this
                    };
                    if (win.ShowDialog() == true) RefreshAll();
                }
                else throw new Exception();
            }
            catch
            {
                MessageBox.Show("Перед изменением предмета для студента, необходимо его выбрать после выбора студента!", "Изменение предмета", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (StudentsMainInfo != null)
                {
                    if (StudentsMainInfo.SelectedItem == null) throw new Exception();
                    Students.Remove((Student)StudentsMainInfo.SelectedItem);
                    RefreshAll();
                }
                else throw new Exception();
            }
            catch
            {
                MessageBox.Show("Перед удалением студента, необходимо его выбрать!", "Удаление студента", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DeleteSubject_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (YearsAndMarks != null)
                {
                    if (CurrentSturdentID == -1) throw new Exception();
                    if (YearsAndMarks.SelectedItem == null) throw new Exception();
                    Students.Find(student => 
                    student.StudentID == CurrentSturdentID).Subjects.Remove((Subject)YearsAndMarks.SelectedItem);
                    RefreshAll();
                }
                else throw new Exception();
            }
            catch
            {
                MessageBox.Show("Перед удалением предмета, необходимо его выбрать после выбора студента!", "Удаление студента", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Лопаткин Сергей ИСП-41\n" +
                "GitHub.Name = HaproBishop\n" +
                "Задача: составить список учебной группы, включающей 25 человек. Для каждого " +
                "учащегося указать дату рождения, год поступления в колледж, курс, группу, оценки " +
                "каждого года обучения. " +
                "\nНазначение задачи: получить значение определѐнного критерия и упорядочить " +
                "список студентов по нему. " +
                "\nДостигаемая цель: упорядочить список студентов по среднему баллу и получить его", "Справка", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
