using System;

// Base class
class Person
{
    // Private data member
    private string name;

    // Protected data member
    protected int age;

    // Public data member
    public string city;

    // Public method to set private data
    public void SetName(string n)
    {
        name = n;
    }

    // Public method to display base class data
    public void ShowPerson()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("City: " + city);
    }

    // Public method to set protected data
    public void SetAge(int a)
    {
        age = a;
    }
}

// Derived class
class Student : Person
{
    // Private data member
    private int rollNo;

    // Protected data member
    protected string course;

    // Public data member
    public double marks;

    // Method to set student details
    public void SetStudent(int r, string c, double m)
    {
        rollNo = r;
        course = c;
        marks = m;
    }

    // Method to display student details
    public void ShowStudent()
    {
        Console.WriteLine("Roll No: " + rollNo);
        Console.WriteLine("Course: " + course);
        Console.WriteLine("Marks: " + marks);
    }
}

// Demo class
class T4_3
{
    static void Main()
    {
        // First object
        Student s1 = new Student();

        s1.SetName("Ansh");
        s1.SetAge(20);
        s1.city = "Rajkot";
        s1.SetStudent(1, "BCA", 85);

        Console.WriteLine("Student 1");
        s1.ShowPerson();
        s1.ShowStudent();

        Console.WriteLine();

        // Second object
        Student s2 = new Student();

        s2.SetName("Rahul");
        s2.SetAge(21);
        s2.city = "Ahmedabad";
        s2.SetStudent(2, "BCA", 90);

        Console.WriteLine("Student 2");
        s2.ShowPerson();
        s2.ShowStudent();
    }
}