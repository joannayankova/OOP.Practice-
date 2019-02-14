namespace ConsoleApp4
{
    public class Circle : Shape
    {
        public double Radius { get; private set; }

        public Circle(double radius) : base()
        {
          this.Radius=radius;
        }
       
        public override double CalculateSurface()
        {
            return this.Radius * this.Radius;
        }
    }
}
