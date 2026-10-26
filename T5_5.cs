using System;

class Program
{
    static void Main()
    {
        int[] a = { 10, 20, 10, 30, 20, 40, 10 };
        int count = 0;

        for (int i = 0; i < a.Length; i++)
        {
            bool alreadyCounted = false;

            for (int k = 0; k < i; k++)
            {
                if (a[i] == a[k])
                {
                    alreadyCounted = true;
                    break;
                }
            }

            if (alreadyCounted)
                continue;

            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[i] == a[j])
                {
                    count++;
                    break;
                }
            }
        }

        Console.WriteLine("Total duplicate elements: " + count);
    }
}