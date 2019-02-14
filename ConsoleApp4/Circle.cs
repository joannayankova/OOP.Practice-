using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Circle : Shape
    {
        double radius;

        public Circle(double radius) : base()
        {
          this.radius=radius;
        }
       
        public override double CalculateSurface()
        {
            return this.radius * this.radius;
        }
    }
}
