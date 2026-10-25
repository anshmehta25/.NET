using System;

class MyClient
{
    public static void Main()
    {
        try
        {
            int x = 0;
            int div = 100 / x;

            Console.WriteLine(div);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        finally
        {
            Console.WriteLine("Finally block executed.");
        }
    }
}