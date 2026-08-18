using System;

class User
{
    public void Display()
    {
        Console.WriteLine("Base User Information");
    }
}

class Student : User
{
    public new void Display()
    {
        Console.WriteLine("Student Information");
    }
}

class T3_22
{
    static void Main()
    {
        Student s = new Student();
        s.Display();
    }
}