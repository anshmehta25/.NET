using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    internal class reverse
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Input A String:");
            string str = Console.ReadLine();

            string rev = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev = rev + str[i];
            }
            Console.WriteLine(rev);
        }
    }
}
