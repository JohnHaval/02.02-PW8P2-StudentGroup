using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW8P2_StudentGroup
{
    public class Student
    {
        public static int IDCounter { get; private set; } = 1;
        public int StudentID { get; private set; }
        public string SecondName { get; set; }
        public DateTime BornDate { get; set; }
        public int EnterYear { get; set; }
        public int Course { get; set; }
        public string Group { get; set; }
        /// <summary>
        /// Key - year, Value - mark
        /// </summary>
        public Dictionary<int, Subject> YearMarks;

        public Student()
        {
            StudentID = IDCounter++;
            YearMarks = new Dictionary<int, Subject>();
        }
        public Student(string secondName)
        {
            StudentID = IDCounter++;
            YearMarks = new Dictionary<int, Subject>();
            SecondName = secondName;
        }
        public Student(string secondName, DateTime bornDate)
        {
            StudentID = IDCounter++;
            YearMarks = new Dictionary<int, Subject>();
            SecondName = secondName;
            BornDate = bornDate;
        }
        public Student(string secondName, DateTime bornDate, int enterYear)
        {
            StudentID = IDCounter++;
            YearMarks = new Dictionary<int, Subject>();
            SecondName = secondName;
            BornDate = bornDate;
            EnterYear = enterYear;
        }
        public Student(string secondName, DateTime bornDate, int enterYear, int course)
        {
            StudentID = IDCounter++;
            YearMarks = new Dictionary<int, Subject>();
            SecondName = secondName;
            BornDate = bornDate;
            EnterYear = enterYear;
            Course = course;
        }
        public Student(string secondName, DateTime bornDate, int enterYear, int course, string group)
        {
            StudentID = IDCounter++;
            YearMarks = new Dictionary<int, Subject>();
            SecondName = secondName;
            BornDate = bornDate;
            EnterYear = enterYear;
            Course = course;
            Group = group;
        }
        public Student(string secondName, DateTime bornDate, int enterYear, int course, string group, Dictionary<int, Subject> subjects)
        {
            StudentID = IDCounter++;
            YearMarks = new Dictionary<int, Subject>();
            SecondName = secondName;
            BornDate = bornDate;
            EnterYear = enterYear;
            Course = course;
            Group = group;
            TransferYearMarks(subjects, false);
        }
        public void TransferYearMarks(Dictionary<int, Subject> subjects, bool isNew)
        {
            if (isNew)
            {
                CreateYearMarks(subjects);
            }
            else UpdateYearMarks(subjects);
        }
        private void CreateYearMarks(Dictionary<int, Subject> subjects)
        {
            YearMarks = new Dictionary<int, Subject>();
            foreach (var value in subjects)
            {
                YearComplete(value.Key, value.Value);
            }

        }
        private void UpdateYearMarks(Dictionary<int, Subject> subjects)
        {
            foreach (var value in subjects)
            {
                if (YearMarks.ContainsKey(value.Key))
                {
                    YearMarks[value.Key] = value.Value;
                }
                else
                {
                    YearComplete(value.Key, value.Value);
                }
            }
        }
        public void YearComplete(int id, Subject subjects)
        {
            YearMarks.Add(id, subjects);
        }        
    }
}
