using System;
using System.Threading;

class T6_14
{
    static void Work()
    {
        Console.WriteLine("Thread is running.");

        Thread.Sleep(1000);

        Console.WriteLine("Thread work completed.");
    }

    static void Main()
    {
        Thread t = new Thread(Work);

        Console.WriteLine("Before Start: " + t.ThreadState);

        t.Start();

        Console.WriteLine("After Start: " + t.ThreadState);

        t.Join();

        Console.WriteLine("After Join: " + t.ThreadState);
        Console.WriteLine("Main thread completed.");
    }
}
