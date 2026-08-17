using System;

class Employee
{
    private int empId;
    private string name;
    private double basicSalary;

    public Employee(int empId, string name, double basicSalary)
    {
        this.empId = empId;
        this.name = name;
        this.basicSalary = basicSalary;
    }

    public double CalculateNetSalary()
    {
        double hra = basicSalary * 0.10;
        double da = basicSalary * 0.05;
        double tax = basicSalary * 0.02;
        return basicSalary + hra + da - tax;
    }

    public void Display()
    {
        Console.WriteLine("Employee ID: " + empId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Net Salary: " + CalculateNetSalary());
    }
}

class T3_10
{
    static void Main()
    {
        Employee e = new Employee(1, "Raj", 20000);
        e.Display();
    }
}