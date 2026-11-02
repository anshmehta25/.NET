
using System;

class T6_7
{
    static void Main()
    {
        try
        {
            Console.Write("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number: " + number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid integer.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Number is out of range.");
        }
        finally
        {
            Console.WriteLine("Finally block executed.");
        }
    }
}
