using ShapeAreaCalculator.Helpers;

namespace ShapeAreaCalculator.Shapes
{
    public class Circle : Shape
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            CircleHelper.CheckRadius(Radius);

            return Math.Pow(Radius, 2) * Math.PI;
        }
    }
}
