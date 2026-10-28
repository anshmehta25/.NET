using System;

class Program
{
    static void Main()
    {
        int[] a = { 10, 20, 30, 40, 50 };

        Console.Write("Enter position to delete (1-5): ");
        int pos = Convert.ToInt32(Console.ReadLine());

        if (pos < 1 || pos > a.Length)
        {
            Console.WriteLine("Invalid position.");
            return;
        }

        for (int i = pos - 1; i < a.Length - 1; i++)
        {
            a[i] = a[i + 1];
        }

        Console.WriteLine("Array after deletion:");

        for (int i = 0; i < a.Length - 1; i++)
        {
            Console.Write(a[i] + " ");
        }
    }
}