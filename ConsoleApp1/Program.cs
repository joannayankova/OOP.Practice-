using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher ivanka = new Teacher("Ivanka", "georgiev");
            Teacher asdf = new Teacher("", "");
            Teacher fadfd = new Teacher("  ", "  ");
            Teacher fgasfadf = new Teacher("123123asdfsa  ", "222  ");
            Teacher fasdfasdf = new Teacher(null, null);

            ivanka.Teach(new Course("math", 7));

            List<Teacher> teachers = new List<Teacher>();

            teachers.Add(ivanka);
            teachers.Add(new Teacher("Gerogi", "Ivanov"));

            List<Student> students = new List<Student>();
            students.Add(new Student("Georgi", "Georgiev"));
            students.Add(new Student("Ivan", "Ivanov"));

            Class newclass1 = new Class(students, teachers);
            Class newclass2 = new Class(students, teachers);

            School School = new School(new List<Class> { newclass1, newclass2 });
            ShowTeacherCourses(ivanka);

            Console.WriteLine(students[1].Firstname);
            Console.ReadLine();
        }

        static void ShowTeacherCourses(Teacher teacher)
        {
            foreach (var courses in teacher.Courses)
            {
                Console.WriteLine(courses.Name);
            }
        }
    }
}
