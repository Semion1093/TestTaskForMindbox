// See https://aka.ms/new-console-template for more information
using ShapeAreaCalculator;
using ShapeAreaCalculator.Shapes;

Console.WriteLine("Hello, World!");

Console.Write($"Укажите радиус: ");
var input = Convert.ToDouble(Console.ReadLine());
var circle = new Circle(input);
var circleArea = Calculator.CalculateArea(circle);
Console.WriteLine($"Площадь круга равна {circleArea}");

Console.Write($"Укажите сторону треугольника: ");
var sideA = Convert.ToDouble(Console.ReadLine());
Console.Write($"Укажите сторону треугольника: ");
var sideB = Convert.ToDouble(Console.ReadLine());
Console.Write($"Укажите сторону треугольника: ");
var sideC = Convert.ToDouble(Console.ReadLine());

var triangle = new Triangle(sideA, sideB, sideC);
var triangleArea = Calculator.CalculateArea(triangle);
Console.WriteLine($"Площадь треугольника равна {triangleArea}");
var isRectangular = triangle.CheckIsTriangleIsRectangular();

if (isRectangular)
    Console.WriteLine("Треугольник прямоугольный");
else
    Console.WriteLine("Треугольник непрямоугольный");