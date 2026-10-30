
using System;

delegate void StudentInfo();

class T6_4
{
    static void DisplayName()
    {
        Console.WriteLine("Name: Rahul");
    }

    static void DisplayCourse()
    {
        Console.WriteLine("Course: BCA");
    }

    static void DisplaySemester()
    {
        Console.WriteLine("Semester: 5");
    }

    static void Main()
    {
        StudentInfo s = DisplayName;
        s += DisplayCourse;
        s += DisplaySemester;

        s();
    }
}