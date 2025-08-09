using System;

abstract class Shape
{
    // Abstract method (no body here)
    public abstract double GetArea();
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a Circle with radius 5
        Shape circle = new Circle(5);
        Console.WriteLine("Circle Area: " + circle.GetArea());

        // Create a Rectangle with width 4 and height 6
        Shape rectangle = new Rectangle(4, 6);
        Console.WriteLine("Rectangle Area: " + rectangle.GetArea());
    }
}
