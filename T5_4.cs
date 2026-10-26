using System;

class Program
{
    static void Main()
    {
        int[] a = { 10, 20, 30, 40, 50 };
        int[] b = new int[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            b[i] = a[i];
        }

        Console.WriteLine("Elements of the second array:");
        for (int i = 0; i < b.Length; i++)
        {
            Console.Write(b[i] + " ");
        }
    }
}