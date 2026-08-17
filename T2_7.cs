using System;

namespace CalculatorApplication
{
    class NumberManipulator
    {
        public void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }

    class T2_7
    {
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();

            int a = 10;
            int b = 20;

            Console.WriteLine("Before swap, value of a : {0}", a);
            Console.WriteLine("Before swap, value of b : {0}", b);

            n.Swap(ref a, ref b);

            Console.WriteLine("After swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);

            Console.ReadLine();
        }
    }
}