using System;

sealed class A
{
    public int x;
    public int y;
}

// Error: A is sealed, so it cannot be inherited.
// class B : A
// {
//     public int z;
// }

class T4_7
{
    static void Main()
    {
        A sc = new A();

        sc.x = 110;
        sc.y = 150;

        Console.WriteLine("x = {0}, y = {1}", sc.x, sc.y);
    }
}