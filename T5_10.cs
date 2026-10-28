using System;

class Program
{
    static void Main()
    {
        int[,] a = {
            { 1, 2 },
            { 3, 4 }
        };

        int[,] b = {
            { 5, 6 },
            { 7, 8 }
        };

        int[,] sum = new int[2, 2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                sum[i, j] = a[i, j] + b[i, j];
            }
        }

        Console.WriteLine("Sum of two matrices:");

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(sum[i, j] + "\t");
            }

            Console.WriteLine();
        }
    }
}