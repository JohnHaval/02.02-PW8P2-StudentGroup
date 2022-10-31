using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW8P2_StudentGroup
{
    public struct Subject
    {
        private int _mark;
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int Mark
        {
            get => _mark; 
            set
            {
                if (value < 2 || value > 5) throw new Exception("Ошибка оценки");
                _mark = value;
            }
        }
        public Subject(int id, string name, int year, int mark)
        {
            StudentID = id;
            Name = name;
            Year = year;
            _mark = mark;
        }
        public void UpdateData(string name, int year, int mark)
        {
            Name = name;
            Year = year;
            Mark = mark;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public static bool operator ==(Subject sub1, Subject sub2)
        {
            if (sub1.StudentID == sub2.StudentID && sub1.Name == sub2.Name && sub1.Year == sub2.Year && sub1.Mark == sub2.Mark) return true;
            return false;
        }
        public static bool operator !=(Subject sub1, Subject sub2)
        {
            if (sub1 == sub2) return false;
            return true;
        }
    }
}
