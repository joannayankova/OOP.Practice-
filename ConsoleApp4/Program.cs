using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] Shapes = new Shape[] { new Rectangle(5, 8), new Circle(2), new Triangle(5, 8), new Circle(10), new Rectangle(7, 8) };

            foreach (var item in Shapes)
            {
                Console.WriteLine(item.CalculateSurface());
            }
           
        }
    }
}
