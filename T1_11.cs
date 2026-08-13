using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tutorials
{
    internal class T1_11
    {
        static void Main(String[] args)
        {
            string name;
            char gender;

            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter gender(M/F): ");
            gender = Convert.ToChar(Console.ReadLine());

            if (gender == 'M' || gender == 'm')
            {
                Console.WriteLine("Mr " + name);
            }
            else if (gender == 'F' || gender == 'f')
            {
                Console.WriteLine("Ms " + name);
            }
            else
            {
                Console.WriteLine("invalid gender");
            }
            Console.ReadLine();
        }
    }
}