using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Course
    {
        public Course(string name, int countExercises)
        {
            if (string.IsNullOrWhiteSpace(name) == false) throw new ArgumentNullException(nameof(name));
            if (countExercises < 0) throw new ArgumentOutOfRangeException(nameof(countExercises));

            Name = name;
            CountOfExercises = countExercises;
        }

        public string Name { get; private set; }

        public int CountOfExercises { get; private set; }

        public int CountOfClases { get; private set; }

        public void AssignToClass()
        {
            CountOfClases++;
        }
    }
}
