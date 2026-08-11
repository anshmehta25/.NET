using System;

namespace Tutorials
{
    internal class T1_5
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");

            int n = int.Parse(Console.ReadLine());
            int fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }

            Console.WriteLine("Factorial is: " + fact);
        }
    }
}