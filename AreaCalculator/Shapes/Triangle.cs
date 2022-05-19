using ShapeAreaCalculator.Helpers;

namespace ShapeAreaCalculator.Shapes
{
    public class Triangle : Shape
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double CalculateArea()
        {
            TriangleHelper.CheckSidesIsValid(SideA, SideB, SideC);
            TriangleHelper.CheckIsTriangleExist(SideA, SideB, SideC);

            var halfOfPerimeter = (SideA + SideB + SideC) / 2;
            var square = Math.Sqrt(halfOfPerimeter * (halfOfPerimeter - SideA)
                * (halfOfPerimeter - SideB) * (halfOfPerimeter - SideC));

            return square;
        }

        public bool CheckIsTriangleIsRectangular()
        {
            TriangleHelper.CheckSidesIsValid(SideA, SideB, SideC);
            TriangleHelper.CheckIsTriangleExist(SideA, SideB, SideC);

            var isRectangular = SideA == Math.Sqrt(Math.Pow(SideB, 2) + Math.Pow(SideC, 2))
                               || SideB == Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideC, 2))
                               || SideC == Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2));

            return isRectangular;
        }
    }
}
