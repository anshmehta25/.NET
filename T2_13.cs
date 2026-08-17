using System;

class T2_13
{
    static void Main(string[] args)
    {
        int amount;

        Console.Write("Enter the amount: ");
        amount = Convert.ToInt32(Console.ReadLine());

        int[] notes = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };

        Console.WriteLine("\nMinimum number of notes required:");

        for (int i = 0; i < notes.Length; i++)
        {
            if (amount >= notes[i])
            {
                int count = amount / notes[i];
                Console.WriteLine("{0} x {1}", notes[i], count);
                amount = amount % notes[i];
            }
        }

        Console.ReadLine();
    }
}