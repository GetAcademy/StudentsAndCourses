﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsAndCourses
{
    public class Course
    {
        private readonly List<Student> _students;
        public string Name { get; }

        public Course(string name)
        {
            _students = new List<Student>();
            Name = name;
        }

        public void RegisterStudent(Student student)
        {
            _students.Add(student);
            student.RegisterCourse2(this);
        }

        public void RegisterStudent2(Student student)
        {
            _students.Add(student);
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