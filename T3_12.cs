using System;

class Student
{
    public int EnrolmentNo { get; set; }
    public string Name { get; set; }
}

class T3_12
{
    static void Main()
    {
        Student s = new Student();
        s.EnrolmentNo = 101;
        s.Name = "Priya";

        Console.WriteLine("Enrollment No: " + s.EnrolmentNo);
        Console.WriteLine("Name: " + s.Name);
    }
}