using System;
using System.Collections.Generic;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle("Rectangle", 10, 5, 3);
        Circle circle = new Circle("Circle", 20, 2);
        Triangle triangle = new Triangle("Triangle", 15, 4, 6);

        rectangle.PrintInfo();
        circle.PrintInfo();
        triangle.PrintInfo();

        Console.WriteLine($"Perimeter of {rectangle.Name}: {rectangle.GetPerimeter()}");
        Console.WriteLine($"Circumference of {circle.Name}: {circle.GetCircumference()}");
        Console.WriteLine($"Height of {triangle.Name}: {triangle.GetHeight()}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(rectangle);
        shapes.Add(circle);
        shapes.Add(triangle);
    }
}
