using System;

class Program
{
    static void Main()
    {
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };

        int[] even = new int[a.Length];
        int[] odd = new int[a.Length];

        int e = 0, o = 0;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] % 2 == 0)
                even[e++] = a[i];
            else
                odd[o++] = a[i];
        }

        Console.Write("Even numbers: ");
        for (int i = 0; i < e; i++)
            Console.Write(even[i] + " ");

        Console.Write("\nOdd numbers: ");
        for (int i = 0; i < o; i++)
            Console.Write(odd[i] + " ");
    }
}