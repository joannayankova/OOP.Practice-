using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
  public abstract  class Shape
    {
        public Shape() { }
        public Shape(double height, double width)
        {
            this.width = width;
            this.height = height;
        }
        public abstract double CalculateSurface();
        public double height;
        public double width;
    }
}
