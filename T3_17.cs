using System;

class Shape
{
    public virtual void Area()
    {
        Console.WriteLine("Area of shape");
    }
}

class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override void Area()
    {
        Console.WriteLine("Area of Circle: " + (3.14 * radius * radius));
    }
}

class Rectangle : Shape
{
    private double length, width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override void Area()
    {
        Console.WriteLine("Area of Rectangle: " + (length * width));
    }
}

class T3_17
{
    static void Main()
    {
        Shape s1 = new Circle(5);
        Shape s2 = new Rectangle(4, 6);

        s1.Area();
        s2.Area();
    }
}