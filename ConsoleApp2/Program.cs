using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee("Ivan", "Draganov", 1500, 160);
           

            List<Student> Students = new List <Student> () {
                new Student(5.50, "marin", "marinov"),
                new Student(3, "sda", "asd"),
                new Student(2.60, "gh", "marigfhnov"),
                new Student(4, "margfhin", "marifhgnov"),
                new Student(5.95, "marifghn", "mfgharinov"),
                new Student(6, "marifghn", "mgharinov"),
                new Student(5.50, "mahrin", "marfghinov"),
                new Student(3.50, "marhhin", "marigfhnov"),
                new Student(2, "marihn", "marhinov"),
                new Student(3.2, "marhhhhin", "marinhov")
                };

            List<Employee> Employees = new List<Employee>() {
                new Employee("marin", "marinov",1500,150),
                new Employee("marin", "Ivanov",3000,150),
                new Employee("marin", "marinov",52200,150),
                new Employee("marin", "marinov",15000,150),
                new Employee("marin", "marinov",5500,150),
                new Employee("marin", "marinov",3500,150),
                new Employee("marin", "marinov",8500,150),
                };
            Students.Sort();

            Employees.Sort();
            foreach (Employee employee in Employees)
            {
                Console.WriteLine(employee._wage);
            }

            //Student temp;

            //for (int i = 0; i < Students.Length - 1; i++)
            //{
            //    for (int j = 0; j < Students.Length - i - 1; j++)
            //    {
            //        if (Students[j] > Students[j + 1])
            //        {
            //            temp = Students[j];
            //            Students[j] = Students[j + 1];
            //            Students[j + 1] = temp;

            //        }

            //    }
            //}



            foreach (Student mark in Students)
            {
                Console.WriteLine(mark.Mark);
            }
            Console.ReadLine();
        }

    }
}
