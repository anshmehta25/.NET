using System;

class Person
{
    protected string name;
    protected int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}

class Student : Person
{
    private int rollNo;

    public Student(string name, int age, int rollNo) : base(name, age)
    {
        this.rollNo = rollNo;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Roll No: " + rollNo);
    }
}

class T3_15
{
    static void Main()
    {
        Student s = new Student("Amit", 20, 101);
        s.Display();
    }
}
