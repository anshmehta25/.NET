using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tutorials
{
    internal class T1_9
    {
        static void Main(string[] args)
        {
            string name, result = "";

            Console.Write("Enter a string to convert to toggle case: ");
            name = Console.ReadLine();

            foreach (char ch in name)
            {
                if (char.IsUpper(ch))
                {
                    result += char.ToLower(ch);
                }
                else if (char.IsLower(ch))
                {
                    result += char.ToUpper(ch);
                }
                else
                {
                    result += ch;
                }
            }

            Console.WriteLine("Toggle case converted: " + result);
            Console.ReadLine();
        }
    }
}