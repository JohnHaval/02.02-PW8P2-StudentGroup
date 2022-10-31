using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PW8P2_StudentGroup;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnitTestTasks
{
    [TestClass]
    public class SortUnitTest
    {
        [TestMethod]
        public void SortTestToUp()
        {
            List<Student> students = AutoFillWithoutGUI.AutoFillList();
            students.Sort(new Comparison<Student>((x, y) => String.Compare(x.SecondName, y.SecondName)));
            Trace.WriteLine(students[0].SecondName);
            Assert.IsTrue(students[0].SecondName == "Авоськин");
        }
        [TestMethod]
        public void SortTestToDown()
        {
            List<Student> students = AutoFillWithoutGUI.AutoFillList();
            students.Sort(new Comparison<Student>((x, y) => String.Compare(y.SecondName, x.SecondName)));
            Trace.WriteLine(students[0].SecondName);
            Assert.IsTrue(students[0].SecondName == "Струганов");
        }
    }
}
