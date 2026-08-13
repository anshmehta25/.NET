using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tutorials
{
    internal class T1_20
    {
        static void Main(string[] args)
        {
            int num = 1;

            for (int i = 1; i <= 4; i++)
            {
                for (int s = 4; s > i; s--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}