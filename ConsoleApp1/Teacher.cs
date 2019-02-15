using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Teacher : Person
    {
        public List<Course> Courses { get; private set; }

        public Teacher(string firstName, string lastName) : base(firstName, lastName)
        {
            Courses = new List<Course>();
        }

        public void Teach(Course course)
        {
            if (course is null) throw new ArgumentNullException(nameof(course));

            Courses.Add(course);
        }
    }
}
