using System;

abstract class Test
{
    protected int a;

    public abstract void A();
}

class Example1 : Test
{
    public override void A()
    {
        Console.WriteLine("Example1.A");
        a++;
    }
}

class Example2 : Test
{
    public override void A()
    {
        Console.WriteLine("Example2.A");
        a--;
    }
}

class T4_6
{
    static void Main()
    {
        Test test1 = new Example1();
        test1.A();

        Test test2 = new Example2();
        test2.A();
    }
}