using System;

class Employee
{
    protected string name;
    protected double salary;

    public Employee(string name, double salary)
    {
        this.name = name;
        this.salary = salary;
    }
}

class Manager : Employee
{
    public Manager(string name, double salary) : base(name, salary)
    {
    }

    public void DisplaySalary()
    {
        Console.WriteLine("Manager Salary: " + (salary + 5000));
    }
}

class Clerk : Employee
{
    public Clerk(string name, double salary) : base(name, salary)
    {
    }

    public void DisplaySalary()
    {
        Console.WriteLine("Clerk Salary: " + (salary + 2000));
    }
}

class T3_16
{
    static void Main()
    {
        Manager m = new Manager("Raj", 30000);
        Clerk c = new Clerk("Jay", 15000);

        m.DisplaySalary();
        c.DisplaySalary();
    }
}