using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsAndCourses
{
    public class Student
    {
        private readonly List<Course> _courses;
        public string Name { get; }

        public Student(string name)
        {
            _courses = new List<Course>();
            Name = name;
        }

        public void RegisterCourse(Course course)
        {
            _courses.Add(course);
            course.RegisterStudent2(this);
        }

        public void RegisterCourse2(Course course)
        {
            _courses.Add(course);
        }

        public string GetCourses()
        {
            var startTxt = $"Student {Name}\r\n\r\nKurs:\r\n";
            foreach (var course in _courses)
            {
                startTxt += $" - {course.Name}\r\n";
            }
            return startTxt;
        }
    }
}
