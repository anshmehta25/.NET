using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tutorials
{
    internal class T1_8
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("enter name to convert to uppercase: ");
            name = Console.ReadLine();

            Console.WriteLine("uppercase result is : " + name.ToUpper());
            Console.ReadLine();
        }
    }
}