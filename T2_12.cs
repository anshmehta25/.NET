using System;

class T2_12
{
    static void Main(string[] args)
    {
        int n;

        Console.Write("Enter the number of elements: ");
        n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter the array elements:");

        for (int i = 0; i < n; i++)
        {
            Console.Write("Element {0}: ", i + 1);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter the element to search: ");
        int x = Convert.ToInt32(Console.ReadLine());

        int found = 0;

        for (int i = 0; i < n; i++)
        {
            if (arr[i] == x)
            {
                found = 1;
                break;
            }
        }

        Console.WriteLine(found);

        Console.ReadLine();
    }
}