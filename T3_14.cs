using System;

class Employee
{
    private double salary;

    public void SetSalary(double salary)
    {
        if (salary > 0)
            this.salary = salary;
    }

    public double GetSalary()
    {
        return salary;
    }
}

class T3_14
{
    static void Main()
    {
        Employee e = new Employee();
        e.SetSalary(25000);

        Console.WriteLine("Salary: " + e.GetSalary());
    }
}
