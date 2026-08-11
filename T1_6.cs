using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tutorials
{
    internal class T1_6
    {
        static void Main(string[] args)
        {
            int a, b, c, result;
            string str;
            Console.Write("Enter Number 1 : ");
            str = Console.ReadLine();          // Missing Statement
            a = Convert.ToInt32(str);
            Console.Write("Enter Number 2 : ");
            str = Console.ReadLine();          // Missing Statement
            b = Convert.ToInt32(str);
            Console.Write("Enter Number 3 : ");
            str = Console.ReadLine();
            c = Convert.ToInt32(str);          // Missing Statement
            result = Sum(a, b, c);
            Console.WriteLine("Sum : " + result); // Missing Statement
            Console.Read();
        }
        static int Sum(int x, int y, int z)
        {
            int res;
            res = x + y + z;
            return res;
        }
    }
}