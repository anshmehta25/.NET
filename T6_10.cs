
using System;
using System.Collections.Generic;

class T6_10
{
    static void Main()
    {
        List<int> marks = new List<int>
        {
            45, 78, 90, 35, 65, 50, 82
        };

        Console.WriteLine("Marks greater than 50:");

        marks.FindAll(m => m > 50)
             .ForEach(m => Console.WriteLine(m));
    }
}
