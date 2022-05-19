namespace ShapeAreaCalculator.Helpers
{
    public class TriangleHelper
    {
        public static void CheckSidesIsValid(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Side length must be greater than 0");
            }
        }

        public static void CheckIsTriangleExist(double sideA, double sideB, double sideC)
        {
            if (sideA + sideB < sideC || sideB + sideC < sideA || sideA + sideC < sideB)
            {
                throw new ArgumentException("Sides do not form a triangle");
            }
        }
    }
}
