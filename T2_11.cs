using System;

class T2_11
{
    static void Main(string[] args)
    {
        int n, sum = 0;

        Console.Write("Enter the number of elements: ");
        n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter the array elements:");

        for (int i = 0; i < n; i++)
        {
            Console.Write("Element {0}: ", i + 1);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            sum += arr[i];
        }

        Console.WriteLine("Sum of array elements = " + sum);

        Console.ReadLine();
    }
}