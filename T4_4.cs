using System;

class StaticVar
{
    public static int num;

    public StaticVar()
    {
        num++;
    }

    // Missing statement
    public static int getNum()
    {
        return num;
    }
}

class StaticTester
{
    static void Main(string[] args)
    {
        StaticVar s1 = new StaticVar();
        StaticVar s2 = new StaticVar();
        StaticVar s3 = new StaticVar();

        Console.WriteLine("Variable num: {0}", StaticVar.getNum());

        Console.ReadKey();
    }
}