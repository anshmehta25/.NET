using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tutorials
{
    internal class T1_21
    {
        static void Main(string[] args)
        {
            int terms, number;
            int sum = 0;
            int current = 0;
            Console.WriteLine("enter terms:");
            terms = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter input number:");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= terms; i++)
            {
                current = current * 10 + number;
                sum += current;
                Console.Write(current);
                if (i < terms)
                    Console.Write(" + ");
            }
            Console.WriteLine(" Sum is " + sum);
            Console.ReadLine();
        }

    }
}