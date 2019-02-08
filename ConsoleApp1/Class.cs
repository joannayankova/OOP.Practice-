using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Class
    {
        public List<Student> students = new List<Student>();

        public List<Teacher> teachers = new List<Teacher>();

        public Class( List<Student> studentinClass,List<Teacher> teachers)
        { 
            this.students = studentinClass;
            this.teachers = teachers;
        }

        public void AddStudents(Student student)
        {
            students.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }
    }
}


