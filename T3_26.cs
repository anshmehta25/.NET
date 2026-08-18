using System;

class T3_26
{
    static void Main()
    {
        string name = "  mr. Ansh mehta ";

        name = name.Trim();
        name = name.Replace("mr.", "Mr.");
        name = name.Insert(0, "Customer: ");
        name = name.ToUpper();

        Console.WriteLine(name);
    }
}