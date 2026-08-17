using System;
using System.Collections.Generic;

class T2_9
{
    static void Main()
    {
        Console.Write("Enter the value of N: ");
        int N;

        while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
        {
            Console.Write("Invalid input. Enter a positive integer: ");
        }

        int size = 2 * N + 2;
        int[] arr = new int[size];

        Console.WriteLine("Enter {0} array elements:", size);

        for (int i = 0; i < size; i++)
        {
            Console.Write("Element {0}: ", i);

            while (!int.TryParse(Console.ReadLine(), out arr[i]))
            {
                Console.Write("Invalid input. Enter an integer: ");
            }
        }

        Dictionary<int, int> frequency = new Dictionary<int, int>();

        foreach (int num in arr)
        {
            if (frequency.ContainsKey(num))
                frequency[num]++;
            else
                frequency[num] = 1;
        }
        Console.WriteLine("\nNumbers occurring exactly once:");

        foreach (KeyValuePair<int, int> item in frequency)
        {
            if (item.Value == 1)
            {
                Console.Write(item.Key + " ");
            }
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}