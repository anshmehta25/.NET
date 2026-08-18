using System;

sealed class Result
{
    private string studentName;
    private int marks;

    public Result(string studentName, int marks)
    {
        this.studentName = studentName;
        this.marks = marks;
    }

    public void DisplayResult()
    {
        Console.WriteLine("Student Name: " + studentName);
        Console.WriteLine("Marks: " + marks);
        Console.WriteLine(marks >= 35 ? "Result: Pass" : "Result: Fail");
    }
}

class T3_24
{
    static void Main()
    {
        Result r = new Result("Amit", 75);
        r.DisplayResult();
    }
}
