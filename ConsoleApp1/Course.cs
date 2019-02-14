using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Course
    {
        public Course(string name,int countExercises)
        {
            Name = name;
            CountOfExercises = countExercises;
        }
   
        public string Name { get; set; }
        public int CountOfExercises{ get; private set; }
        public int CountOfClases { get; private set; }
    }
}
