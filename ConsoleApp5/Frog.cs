using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Frog : Animal
    {
        public Frog(int age, string name, string gender) : base(age, name, gender)
        {
        }

        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("...croak croak ");
        }
    }
}
