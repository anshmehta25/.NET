using System;

public class A
{
    public A(int value)
    {
        Console.WriteLine("Base constructor A()");
    }
}

public class B : A
{
    public B(int value) : base(value)
    {
        Console.WriteLine("Derived constructor B()");
    }
}

class Program
{
    static void Main()
    {
        A a = new A(0);
        B b = new B(1);
    }
}