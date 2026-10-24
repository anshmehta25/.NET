using System;

class X
{
    public virtual void F()
    {
        Console.WriteLine("X.F");
    }

    public virtual void F2()
    {
        Console.WriteLine("X.F2");
    }
}

class Y : X
{
    public sealed override void F()
    {
        Console.WriteLine("Y.F");
    }

    public override void F2()
    {
        Console.WriteLine("Y.F2");
    }
}

class Z : Y
{
    // F() cannot be overridden because it is sealed

    public override void F2()
    {
        Console.WriteLine("Z.F2");
    }
}

class SealedMethodTest
{
    static void Main()
    {
        X Obj1 = new X();

        Obj1.F();

        Obj1.F2();

        Y Obj2 = new Y();

        Obj2.F();

        Obj2.F2();

        Z Obj3 = new Z();

        Obj3.F();

        Obj3.F2();
    }
}