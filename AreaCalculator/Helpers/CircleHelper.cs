namespace ShapeAreaCalculator.Helpers
{
    public static class CircleHelper
    {
        public static void CheckRadius(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius value must be greater than 0");
            }
        }
    }
}
