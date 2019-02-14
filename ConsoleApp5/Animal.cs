using System;

namespace ConsoleApp5
{
    public class Animal
    {
        
        public int Age { get; private set; }
        public string Name { get; set; }
        public string Gender { get;private  set; }

        public Animal(int age, string name, string gender)
        {
            Age = age;
            Name = name;
            Gender = gender;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Make sound....");
        }
    }
};
