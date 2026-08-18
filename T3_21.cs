using System;

class Person
{
    protected string name;

    public Person(string name)
    {
        this.name = name;
    }
}

class Student : Person
{
    private int rollNo;

    public Student(string name, int rollNo) : base(name)
    {
        this.rollNo = rollNo;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Roll No: " + rollNo);
    }
}

class T3_21
{
    static void Main()
    {
        Student s = new Student("Amit", 101);
        s.Display();
    }
}