using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace StudentsAndCourses.UnitTest
{
    class StudentTest
    {
        [Test]
        public void Test1()
        {
            var student = new Student("Per");
            var course = new Course("C#");
            course.RegisterStudent(student);

            var txt = student.GetCourses();
            const string expectedTxt = "Student Per\r\n\r\nKurs:\r\n - C#\r\n";
            Assert.AreEqual(expectedTxt, txt);
        }

        [Test]
        public void Test2()
        {
            var student = new Student("Per");
            var course = new Course("C#");
            student.RegisterCourse(course);

            var txt = course.GetStudents();
            const string expectedTxt = "Kurs C#\r\n\r\nStudenter:\r\n - Per\r\n";
            Assert.AreEqual(expectedTxt, txt);
        }
    }
}
