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
        public double AvgMark { get => GetAvgMark(); }
        public List<Subject> Subjects;

        public Student()
        {
            StudentID = IDCounter++;
            Subjects = new List<Subject>();
        }
        public Student(string secondName)
        {
            StudentID = IDCounter++;
            Subjects = new List<Subject>();
            SecondName = secondName;
        }
        public Student(string secondName, DateTime bornDate)
        {
            StudentID = IDCounter++;
            Subjects = new List<Subject>();
            SecondName = secondName;
            BornDate = bornDate;
        }
        public Student(string secondName, DateTime bornDate, int enterYear)
        {
            StudentID = IDCounter++;
            Subjects = new List<Subject>();
            SecondName = secondName;
            BornDate = bornDate;
            EnterYear = enterYear;
        }
        public Student(string secondName, DateTime bornDate, int enterYear, int course)
        {
            StudentID = IDCounter++;
            Subjects = new List<Subject>();
            SecondName = secondName;
            BornDate = bornDate;
            EnterYear = enterYear;
            Course = course;
        }
        public Student(string secondName, DateTime bornDate, int enterYear, int course, string group)
        {
            StudentID = IDCounter++;
            Subjects = new List<Subject>();
            SecondName = secondName;
            BornDate = bornDate;
            EnterYear = enterYear;
            Course = course;
            Group = group;
        }
        public Student(string secondName, DateTime bornDate, int enterYear, int course, string group, List<Subject> subjects)
        {
            StudentID = IDCounter++;
            Subjects = new List<Subject>();
            SecondName = secondName;
            BornDate = bornDate;
            EnterYear = enterYear;
            Course = course;
            Group = group;
            TransferYearMarks(subjects, false);
        }
        public void TransferYearMarks(List<Subject> subjects, bool isNew)
        {
            if (isNew)
            {
                CreateYearMarks(subjects);
            }
            else UpdateYearMarks(subjects);
        }
        private void CreateYearMarks(List<Subject> subjects)
        {
            Subjects = new List<Subject>();
            UpdateYearMarks(subjects);
        }
        private void UpdateYearMarks(List<Subject> subjects)
        {
            foreach (var value in subjects)
            {
                YearComplete(value);
            }
        }
        public void YearComplete(Subject subject)
        {
            Subjects.Add(subject);
        }        
        private double GetAvgMark()
        {
            double allMarks = 0;
            for (int i = 0; i < Subjects.Count; i++)
            {
                allMarks += Subjects[i].Mark;
            }
            return Math.Round(allMarks / Subjects.Count, 2);
        }
    }
}
