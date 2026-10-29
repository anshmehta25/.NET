using System;

interface IEmployee
{
    void AcceptDetails();
    void DisplayDetails();
}

class Employee : IEmployee
{
    int id;
    string name;
    double salary;

    public void AcceptDetails()
    {
        Console.Write("Enter Employee ID: ");
        id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Salary: ");
        salary = Convert.ToDouble(Console.ReadLine());
    }

    public void DisplayDetails()
    {
        Console.WriteLine("\nEmployee Details");
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Salary: " + salary);
    }
}

class Program
{
    static void Main()
    {
        Employee e = new Employee();
        e.AcceptDetails();
        e.DisplayDetails();
    }
}