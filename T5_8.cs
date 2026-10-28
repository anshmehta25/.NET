using System;

class Program
{
    static void Main()
    {
        int[] a = { 5, 2, 8, 1, 9 };

        for (int i = 0; i < a.Length - 1; i++)
        {
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[i] < a[j])
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }

        Console.WriteLine("Array in descending order:");

        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + " ");
        }                               
    }
}