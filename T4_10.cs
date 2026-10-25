using System;

class MyException : Exception
{
    public MyException(string str) : base(str)
    {
        Console.WriteLine("User defined exception");
    }
}

class T4_10
{
    public static void Main()
    {
        try
        {
            throw new MyException("my exception generated.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception caught here: " + e.Message);
        }

        Console.WriteLine("LAST STATEMENT");
    }
}