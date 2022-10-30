using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW8P2_StudentGroup
{
    public struct Subject
    {        
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int Mark { get; set; }
        public Subject(int id, string name, int year, int mark)
        {
            StudentID = id;
            Name = name;
            Year = year;
            Mark = mark;
        }
        public void UpdateData(string name, int year, int mark)
        {
            Name = name;
            Year = year;
            Mark = mark;
        }
    }
}
