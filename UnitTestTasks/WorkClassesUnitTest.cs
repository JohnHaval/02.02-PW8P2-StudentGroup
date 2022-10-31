using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PW8P2_StudentGroup;

namespace UnitTestTasks
{
    [TestClass]
    public class WorkClassesUnitTest
    {
        [TestMethod]
        public void AutoFillSubjects()
        {
            List<Subject> subjects = AutoFillWithoutGUI.AutoFillYearsAndMarks();
            Assert.IsNotNull(subjects);
        }
        [TestMethod]
        public void AutoFillStudents()
        {
            List<Student> students = AutoFillWithoutGUI.AutoFillList();
            Assert.IsNotNull(students);
        }
        [TestMethod]
        public void CheckTrueAvgMark()
        {
            var student = new Student();
            student.Subjects.Add(new Subject() { Mark = 3});
            student.Subjects.Add(new Subject() { Mark = 4});
            Assert.IsTrue(student.AvgMark == 3.5);
        }
    }
}
