using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher Ivan = new Teacher("Ivan", "georgiev");
            Ivan.AddCourse(new Course("math"));
            List<Teacher> teachersClass1 = new List<Teacher>();
            teachersClass1.Add(Ivan);
            
            teachersClass1.Add(new Teacher("Gerogi", "Ivanov"));

            List<Student> studentsClass1 = new List<Student>();
            studentsClass1.Add(new Student("Georgi", "Georgiev"));
            studentsClass1.Add(new Student("Ivan", "Ivanov"));
            Class newclass1 = new Class(studentsClass1,teachersClass1);



            School school = new School(newclass1);

            school.classes.AddStudents(new Student ("Mitko", "Dimitrov"));

            school.classes.AddTeacher(new Teacher("Dimitar", "Angelov"));

           

          Ivan.ShowCourses();


            Console.ReadLine();

        }
    }
}
