namespace ShapeAreaCalculator.Tests
{
    public class ShapeAreaCalculatorTests
    {
        [TestCase(1, Math.PI)]
        [TestCase(77, 18626.502843133883)]
        [TestCase(10, 314.15926535897933)]
        public void CalculateArea_Circle_ShouldReturnsCircleArea(double radius, double expected)
        {
            // given
            var circle = new Circle(radius);

            // when
            var actual = Calculator.CountArea(circle);

            // then
            Assert.That(actual, Is.EqualTo(expected));
            Assert.That(circle.Radius, Is.EqualTo(radius));
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-11)]
        public void CalculateArea_CircleRadiusIsInvalid_ShouldThrowArgumentExeption(double radius)
        {
            // given
            var circle = new Circle(radius);
            var expectedMessage = "Radius value must be greater than 0";

            //when
            var exception = Assert.Throws<ArgumentException>(() => Calculator.CountArea(circle));

            // then
            Assert.That(exception.Message, Is.EqualTo(expectedMessage));
        }

        [TestCase(2, 3, 5, 0)]
        [TestCase(8, 4, 7, 13.997767679169419)]
        [TestCase(10, 8, 15, 36.978879106863147)]
        public void CalculateArea_Triangle_ShouldReturnsTriangleArea(double sideA, double sideB, double sideC, double expected)
        {
            // given
            var triangle = new Triangle(sideA, sideB, sideC);

            // when
            var actual = Calculator.CountArea(triangle);

            // then
            Assert.That(actual, Is.EqualTo(expected));
            Assert.That(triangle.SideA, Is.EqualTo(sideA));
            Assert.That(triangle.SideB, Is.EqualTo(sideB));
            Assert.That(triangle.SideC, Is.EqualTo(sideC));
        }

        [TestCase(-0.5, 1.6, 2.8)]
        [TestCase(0.5, -1.6, 2.8)]
        [TestCase(0.5, 1.6, -2.8)]
        public void CalculateArea_TriangleSideIsInvalid_ShouldThrowArgumentExeption(double sideA, double sideB, double sideC)
        {
            // given
            var triangle = new Triangle(sideA, sideB, sideC);
            var expectedMessage = "Side length must be greater than 0";

            //when
            var exception = Assert.Throws<ArgumentException>(() => Calculator.CountArea(triangle));

            // then
            Assert.That(exception.Message, Is.EqualTo(expectedMessage));
        }

        [TestCase(0.5, 1.6, 2.8)]
        [TestCase(1.1, 1.6, 2.8)]
        [TestCase(0.5, 0.1, 2.8)]
        public void CalculateArea_TriangleIsNotExsit_ShouldThrowArgumentExeption(double sideA, double sideB, double sideC)
        {
            // given
            var triangle = new Triangle(sideA, sideB, sideC);
            var expectedMessage = "Sides do not form a triangle";

            //when
            var exception = Assert.Throws<ArgumentException>(() => Calculator.CountArea(triangle));

            // then
            Assert.That(exception.Message, Is.EqualTo(expectedMessage));
        }
    }
}