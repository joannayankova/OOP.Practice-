﻿using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Teacher : Person
    {
        public List<Course> Courses { get; private set; }

        public Teacher(string fname, string lname) : base(fname, lname)
        {
            this.Courses = new List<Course>();
        }

        public void AddCourse(Course course)
        {
            if (course is null) throw new ArgumentNullException(nameof(course));
            Courses.Add(course);
        }

        public void ShowCourses()
        {
           foreach(var courses in Courses)
            {
                Console.WriteLine(courses.Name);
            }
        }

    }
}

