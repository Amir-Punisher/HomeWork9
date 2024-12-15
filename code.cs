using System;
using System.Collections.Generic;
public interface IShape
{
    double CalculateArea();
}
public class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}
public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double CalculateArea()
    {
        return Width * Height;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        List<IShape> shapes = new List<IShape>
        {
            new Circle(5),
            new Rectangle(4, 6)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"masahat : {shape.CalculateArea()}");
        }
        Console.ReadKey();
    }
}
