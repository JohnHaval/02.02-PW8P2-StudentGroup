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
                var student = (Student)e.AddedItems[0];
                YearsAndMarks.Items.Clear();
                foreach (var value in student.Subjects)
                {
                    YearsAndMarks.Items.Add($"{value.Year} | {value.Name} | {value.Mark}");
                }
            }
            catch { }
        }
        static Random rnd;
        private void AutoFill_Click(object sender, RoutedEventArgs e)
        {            
            StudentsMainInfo.ItemsSource = AutoFillList();
        }
        public static List<Student> AutoFillList()
        {
            rnd = new Random();
            Students = new List<Student>()
            {
                new Student("Кронов", Convert.ToDateTime($"{rnd.Next(1,31)}.{rnd.Next(1,13)}.{rnd.Next(1970,1990)}"), 2000, 4, "П-41", AutoFillYearsAndMarks()),
                new Student("Плутонов", Convert.ToDateTime($"{rnd.Next(1,31)}.{rnd.Next(1,13)}.{rnd.Next(1970,1990)}"), 2000, 4, "П-41", AutoFillYearsAndMarks()),
                new Student("Ножнов", Convert.ToDateTime($"{rnd.Next(1,31)}.{rnd.Next(1,13)}.{rnd.Next(1970,1990)}"), 2000, 4, "П-41", AutoFillYearsAndMarks()),
                new Student("Криклиев", Convert.ToDateTime($"{rnd.Next(1,31)}.{rnd.Next(1,13)}.{rnd.Next(1970,1990)}"), 2000, 4, "П-41", AutoFillYearsAndMarks()),
                new Student("Потеркин", Convert.ToDateTime($"{rnd.Next(1,31)}.{rnd.Next(1,13)}.{rnd.Next(1970,1990)}"), 2000, 4, "П-41", AutoFillYearsAndMarks()),
                new Student("Струганов", Convert.ToDateTime($"{rnd.Next(1,31)}.{rnd.Next(1,13)}.{rnd.Next(1970,1990)}"), 2000, 4, "П-41", AutoFillYearsAndMarks()),
                new Student("Смирнов", Convert.ToDateTime($"{rnd.Next(1,31)}.{rnd.Next(1,13)}.{rnd.Next(1970,1990)}"), 2000, 4, "П-41", AutoFillYearsAndMarks()),
                new Student("Косов", Convert.ToDateTime($"{rnd.Next(1,31)}.{rnd.Next(1,13)}.{rnd.Next(1970,1990)}"), 2000, 4, "П-41", AutoFillYearsAndMarks()),
                new Student("Иноров", Convert.ToDateTime($"{rnd.Next(1,31)}.{rnd.Next(1,13)}.{rnd.Next(1970,1990)}"), 2000, 4, "П-41", AutoFillYearsAndMarks()),
                new Student("Невоськин", Convert.ToDateTime($"{rnd.Next(1,31)}.{rnd.Next(1,13)}.{rnd.Next(1970,1990)}"), 2000, 4, "П-41", AutoFillYearsAndMarks()),
                new Student("Петров", Convert.ToDateTime($"{rnd.Next(1,31)}.{rnd.Next(1,13)}.{rnd.Next(1970,1990)}"), 2000, 4, "П-41", AutoFillYearsAndMarks()),
                new Student("Иванов", Convert.ToDateTime($"{rnd.Next(1,31)}.{rnd.Next(1,13)}.{rnd.Next(1970,1990)}"), 2000, 4, "П-41", AutoFillYearsAndMarks()),
                new Student("Колисеев", Convert.ToDateTime($"{rnd.Next(1,31)}.{rnd.Next(1,13)}.{rnd.Next(1970,1990)}"), 2000, 4, "П-41", AutoFillYearsAndMarks()),
                new Student("Локоткин", Convert.ToDateTime($"{rnd.Next(1,31)}.{rnd.Next(1,13)}.{rnd.Next(1970,1990)}"), 2000, 4, "П-41", AutoFillYearsAndMarks()),
                new Student("Прямостронов", Convert.ToDateTime($"{rnd.Next(1,31)}.{rnd.Next(1,13)}.{rnd.Next(1970,1990)}"), 2000, 4, "П-41", AutoFillYearsAndMarks()),
                //15, need 25
                new Student("Сверлов", Convert.ToDateTime($"{rnd.Next(1,31)}.{rnd.Next(1,13)}.{rnd.Next(1970,1990)}"), 2000, 4, "П-41", AutoFillYearsAndMarks()),
                new Student("Скосов", Convert.ToDateTime($"{rnd.Next(1,31)}.{rnd.Next(1,13)}.{rnd.Next(1970,1990)}"), 2000, 4, "П-41", AutoFillYearsAndMarks()),
                new Student("Ильев", Convert.ToDateTime($"{rnd.Next(1,31)}.{rnd.Next(1,13)}.{rnd.Next(1970,1990)}"), 2000, 4, "П-41", AutoFillYearsAndMarks()),
                new Student("Касаткин", Convert.ToDateTime($"{rnd.Next(1,31)}.{rnd.Next(1,13)}.{rnd.Next(1970,1990)}"), 2000, 4, "П-41", AutoFillYearsAndMarks()),
                new Student("Авоськин", Convert.ToDateTime($"{rnd.Next(1,31)}.{rnd.Next(1,13)}.{rnd.Next(1970,1990)}"), 2000, 4, "П-41", AutoFillYearsAndMarks()),
                new Student("Попугаев", Convert.ToDateTime($"{rnd.Next(1,31)}.{rnd.Next(1,13)}.{rnd.Next(1970,1990)}"), 2000, 4, "П-41", AutoFillYearsAndMarks()),
                new Student("Неонов", Convert.ToDateTime($"{rnd.Next(1,31)}.{rnd.Next(1,13)}.{rnd.Next(1970,1990)}"), 2000, 4, "П-41", AutoFillYearsAndMarks()),
                new Student("Локомотов", Convert.ToDateTime($"{rnd.Next(1,31)}.{rnd.Next(1,13)}.{rnd.Next(1970,1990)}"), 2000, 4, "П-41", AutoFillYearsAndMarks()),
                new Student("Прямолинейнов", Convert.ToDateTime($"{rnd.Next(1,31)}.{rnd.Next(1,13)}.{rnd.Next(1970,1990)}"), 2000, 4, "П-41", AutoFillYearsAndMarks()),
                new Student("Состряпов", Convert.ToDateTime($"{rnd.Next(1,31)}.{rnd.Next(1,13)}.{rnd.Next(1970,1990)}"), 2000, 4, "П-41", AutoFillYearsAndMarks())
            };
            return Students;
        }
        public static List<Subject> AutoFillYearsAndMarks()
        {            
            var subjects = new List<Subject>();
            for (int i = 0; i < 3; i++)
            {
                var subject1 = new Subject(Student.IDCounter, "СП", 2000 + i, rnd.Next(2, 6));
                var subject2 = new Subject(Student.IDCounter, "РПМ", 2000 + i, rnd.Next(2, 6));
                var subject3 = new Subject(Student.IDCounter, "КС", 2000 + i, rnd.Next(2, 6));
                var subject4 = new Subject(Student.IDCounter, "ВиПКС", 2000 + i, rnd.Next(2, 6));
                var subject5 = new Subject(Student.IDCounter, "ТПМ", 2000 + i, rnd.Next(2, 6));
                var subject6 = new Subject(Student.IDCounter, "ДПП", 2000 + i, rnd.Next(2, 6));
                subjects.Add(subject1);
                subjects.Add(subject2);
                subjects.Add(subject3);
                subjects.Add(subject4);
                subjects.Add(subject5);
                subjects.Add(subject6);
            }
            return subjects;
        }

        private void Sort_Click(object sender, RoutedEventArgs e)
        {
            var win = new SortWindow()
            {
                Owner = this
            };
            if (win.ShowDialog() == true) StudentsMainInfo.Items.Refresh();
        }
    }
}
