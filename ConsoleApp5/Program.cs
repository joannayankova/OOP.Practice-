using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Cat(5, "Tomas", "female"));
            animals.Add(new Dog(10, "Jessy", "female"));
            animals.Add(new Frog (7, "John", "male"));
            animals.Add(new Kitty(8, "Sue", "female"));

            foreach (var sound in animals)
            {
                sound.MakeSound();
            }
        }
    }
}
