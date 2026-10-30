
using System;

delegate double Calculate(double a, double b);

class Program
{
    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Subtract(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static double Divide(double a, double b)
    {
        return a / b;
    }

    static void Main()
    {
        double a = 20, b = 5;

        Calculate c = Add;
        Console.WriteLine("Addition: " + c(a, b));

        c = Subtract;
        Console.WriteLine("Subtraction: " + c(a, b));

        c = Multiply;
        Console.WriteLine("Multiplication: " + c(a, b));

        c = Divide;
        Console.WriteLine("Division: " + c(a, b));
    }
}
