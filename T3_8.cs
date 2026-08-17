using System;

class Student
{
    private int rollNo;
    private string name;

    public Student(int rollNo, string name)
    {
        this.rollNo = rollNo;
        this.name = name;
    }

    public void Display()
    {
        Console.WriteLine("Roll No: " + rollNo);
        Console.WriteLine("Name: " + name);
    }
}

class T3_8
{
    static void Main()
    {
        Student s = new Student(1, "Amit");
        s.Display();
    }
}