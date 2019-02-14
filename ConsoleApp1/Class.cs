using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Class
    {
        public Class( List<Student> students,List<Teacher> teachers)
        {
            if (students is null) throw new ArgumentNullException(nameof(students));
            if (teachers is null) throw new ArgumentNullException(nameof(teachers));

            this.Students = students;
            this.Teachers = teachers;
        }

        public List<Student> Students { get; private set; }

        public List<Teacher> Teachers { get; private set; }

        public void AddStudents(Student student)
        {
            if (student is null) throw new ArgumentNullException(nameof(student));
            Students.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            if (teacher is null) throw new ArgumentNullException(nameof(teacher));
            Teachers.Add(teacher);
        }
    }
}


