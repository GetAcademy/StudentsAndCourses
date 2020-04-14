using NUnit.Framework;

namespace StudentsAndCourses.UnitTest
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var student = new Student("Per");
            var course = new Course("C#");
            course.RegisterStudent(student);

            var txt = course.GetStudents();
            const string expectedTxt = "Kurs C#\r\n\r\nStudenter:\r\n - Per\r\n";
            Assert.AreEqual(expectedTxt, txt);
        }

        [Test]
        public void Test2()
        {
            var student1 = new Student("Per");
            var student2 = new Student("Pål");
            var course = new Course("C#");
            course.RegisterStudent(student1);
            course.RegisterStudent(student2);

            var txt = course.GetStudents();
            const string expectedTxt = "Kurs C#\r\n\r\nStudenter:\r\n - Per\r\n - Pål\r\n";
            Assert.AreEqual(expectedTxt, txt);
        }

        [Test]
        public void Test3()
        {
            var student = new Student("Per");
            var course = new Course("C#");
            course.RegisterStudent(student);

            var txt = student.GetCourses();
            const string expectedTxt = "Student Per\r\n\r\nKurs:\r\n - C#\r\n";
            Assert.AreEqual(expectedTxt, txt);
        }
    }
}