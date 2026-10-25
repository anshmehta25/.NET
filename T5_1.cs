using System;
namespace T5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Array elements are:");
            
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
        }
    }
}