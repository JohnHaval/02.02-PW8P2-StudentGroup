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
    /// Логика взаимодействия для SortWindow.xaml
    /// </summary>
    public partial class SortWindow : Window
    {
        public SortWindow()
        {
            InitializeComponent();            
        }

        private void Sort_Click(object sender, RoutedEventArgs e)
        {
            int iCurrent = SortSelector.SelectedIndex;
            if (iCurrent == 0)
            {
                if(DownSorting.IsChecked == true) MainWindow.Students.Sort(new Comparison<Student>((x, y) => String.Compare(y.StudentID.ToString(), x.StudentID.ToString())));
                else MainWindow.Students.Sort(new Comparison<Student>((x, y) => String.Compare(x.StudentID.ToString(), y.StudentID.ToString())));
            }
            if (iCurrent == 1)
            {                
                if (DownSorting.IsChecked == true) MainWindow.Students.Sort(new Comparison<Student>((x, y) => String.Compare(y.SecondName, x.SecondName)));
                else MainWindow.Students.Sort(new Comparison<Student>((x, y) => String.Compare(x.SecondName, y.SecondName)));
            }
            if (iCurrent == 2)
            {
                if (DownSorting.IsChecked == true) MainWindow.Students.Sort(new Comparison<Student>((x, y) => DateTime.Compare(y.BornDate, x.BornDate)));
                else MainWindow.Students.Sort(new Comparison<Student>((x, y) => DateTime.Compare(x.BornDate, y.BornDate)));
            }
            if (iCurrent == 3)
            {
                if (DownSorting.IsChecked == true) MainWindow.Students.Sort(new Comparison<Student>((x, y) => String.Compare(y.EnterYear.ToString(), x.EnterYear.ToString())));
                else MainWindow.Students.Sort(new Comparison<Student>((x, y) => String.Compare(x.EnterYear.ToString(), y.EnterYear.ToString())));
            }
            if (iCurrent == 4)
            {
                if (DownSorting.IsChecked == true) MainWindow.Students.Sort(new Comparison<Student>((x, y) => String.Compare(y.Course.ToString(), x.Course.ToString())));
                else MainWindow.Students.Sort(new Comparison<Student>((x, y) => String.Compare(x.Course.ToString(), y.Course.ToString())));
            }
            if (iCurrent == 5)
            {
                if (DownSorting.IsChecked == true) MainWindow.Students.Sort(new Comparison<Student>((x, y) => String.Compare(y.Group, x.Group)));
                else MainWindow.Students.Sort(new Comparison<Student>((x, y) => String.Compare(x.Group, y.Group)));
            }
            if (iCurrent == 6)
            {
                if (DownSorting.IsChecked == true) MainWindow.Students.Sort(new Comparison<Student>((x, y) => String.Compare(y.AvgMark.ToString(), x.AvgMark.ToString())));
                else MainWindow.Students.Sort(new Comparison<Student>((x, y) => String.Compare(x.AvgMark.ToString(), y.AvgMark.ToString())));
            }
            DialogResult = true;
            Close();
        }

        private void CancelSort_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
