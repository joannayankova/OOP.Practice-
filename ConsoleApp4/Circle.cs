using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Circle : Shape
    {
        public double Radius { get; private set; }

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
