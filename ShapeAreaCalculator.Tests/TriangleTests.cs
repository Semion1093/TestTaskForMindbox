namespace ShapeAreaCalculator.Tests
{
    public class TriangleTests
    {
        [TestCase(3, 4, 5, true)]
        [TestCase(1, 2, 3, false)]
        public void CheckIsTriangleIsRectangular_ShouldReturnTrueOrFalse(double sideA, double sideB, double sideC, bool isRectangular)
        {
            // given
            var triangle = new Triangle(sideA, sideB, sideC);

            // when
            var actual = triangle.CheckIsTriangleIsRectangular();

            // then
            Assert.That(actual, Is.EqualTo(isRectangular));
        }

        [TestCase(-0.5, 1.6, 2.8)]
        [TestCase(0.5, -1.6, 2.8)]
        [TestCase(0.5, 1.6, -2.8)]
        public void CheckIsTriangleIsRectangular_SideIsInvalid_ShouldThrowArgumentExeption(double sideA, double sideB, double sideC)
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
        public void CheckIsTriangleIsRectangular_TriangleIsNotExsit_ShouldThrowArgumentExeption(double sideA, double sideB, double sideC)
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
