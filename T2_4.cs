using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorials
{
    internal class T2_4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number (A): ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number (B): ");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n--- Arithmetic Operators ---");
            Console.WriteLine("A + B = " + (A + B));
            Console.WriteLine("A - B = " + (A - B));
            Console.WriteLine("A * B = " + (A * B));
            Console.WriteLine("A / B = " + (A / B));
            Console.WriteLine("A % B = " + (A % B));

            Console.WriteLine("\n--- Relational Operators ---");
            Console.WriteLine("A == B : " + (A == B));
            Console.WriteLine("A != B : " + (A != B));
            Console.WriteLine("A > B  : " + (A > B));
            Console.WriteLine("A < B  : " + (A < B));
            Console.WriteLine("A >= B : " + (A >= B));
            Console.WriteLine("A <= B : " + (A <= B));

            Console.WriteLine("\n--- Logical Operators ---");
            Console.WriteLine("(A > 0 && B > 0) : " + (A > 0 && B > 0));
            Console.WriteLine("(A > 0 || B > 0) : " + (A > 0 || B > 0));
            Console.WriteLine("!(A > B) : " + !(A > B));

            Console.WriteLine("\n--- Assignment Operators ---");
            int C = A;
            Console.WriteLine("C = " + C);
            C += B;
            Console.WriteLine("C += B : " + C);
            C -= B;
            Console.WriteLine("C -= B : " + C);
            C *= B;
            Console.WriteLine("C *= B : " + C);

            Console.WriteLine("\n--- Increment / Decrement ---");
            Console.WriteLine("A++ = " + (A++));
            Console.WriteLine("After A++ : " + A);
            Console.WriteLine("--B = " + (--B));

            Console.WriteLine("\n--- Different Data Types ---");
            int i = 100;
            double d = 10.5;
            float f = 5.5f;
            char ch = 'A';
            string str = "C# Programming";
            bool flag = true;

            Console.WriteLine("int = " + i);
            Console.WriteLine("double = " + d);
            Console.WriteLine("float = " + f);
            Console.WriteLine("char = " + ch);
            Console.WriteLine("string = " + str);
            Console.WriteLine("bool = " + flag);

            Console.ReadLine();
        }
    }
}
