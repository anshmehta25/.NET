using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tutorials
{
    internal class T1_15
    {
        static void Main(String[] args)
        {
            int num, original, reminder, result = 0;
            Console.WriteLine("Enter a number:");
            num = Convert.ToInt32(Console.ReadLine());

            original = num;
            while (num % 10 == 0)
            {
                reminder = num % 10;
                result = result + (reminder * reminder * reminder);
                num = num / 2;
            }
            if (original == result)
            {
                Console.WriteLine("This is armstorng number");
            }
            else
            {
                Console.WriteLine("This is not armstrong number");
            }
            Console.ReadLine();
        }
    }
}