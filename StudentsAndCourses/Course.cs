using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsAndCourses
{
    public class Course
    {
        private readonly HashSet<Student> _students;
        public string Name { get; }

        public Course(string name)
        {
            _students = new HashSet<Student>();
            Name = name;
        }

        public void RegisterStudent(Student student, bool notifyStudent = true)
        {
            if (student == null) return;
            _students.Add(student);
            if (notifyStudent) student.RegisterCourse(this, false);
        }

        public string GetStudents()
        {
            var startTxt = $"Kurs {Name}\r\n\r\nStudenter:\r\n";
            foreach (var student in _students)
            {
                startTxt += $" - {student.Name}\r\n";
            }
            return startTxt;
        }
    }
}
