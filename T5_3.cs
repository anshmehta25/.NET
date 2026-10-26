using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];

            Console.WriteLine("Enter elements:");

            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Reverse order:");

            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(a[i]);
            }

            Console.ReadLine();
        }
    }
}