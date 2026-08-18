using System;

class Student
{
    public static int Count = 0;
    private string name;

    public Student(string name)
    {
        this.name = name;
        Count++;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + name);
    }
}

class T3_19
{
    static void Main()
    {
        Student s1 = new Student("Amit");
        Student s2 = new Student("Riya");
        Student s3 = new Student("Jay");

        Console.WriteLine("Total Students: " + Student.Count);
    }
}