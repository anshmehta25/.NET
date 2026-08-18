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

    public virtual void GenerateSalarySlip()
    {
        Console.WriteLine("Employee Salary Slip");
    }
}

class PermanentEmployee : Employee
{
    public PermanentEmployee(string name, double salary) : base(name, salary)
    {
    }

    public override void GenerateSalarySlip()
    {
        Console.WriteLine("Permanent Employee: " + name);
        Console.WriteLine("Salary: " + (salary + 5000));
    }
}

class ContractEmployee : Employee
{
    public ContractEmployee(string name, double salary) : base(name, salary)
    {
    }

    public override void GenerateSalarySlip()
    {
        Console.WriteLine("Contract Employee: " + name);
        Console.WriteLine("Salary: " + salary);
    }
}

class T3_18
{
    static void Main()
    {
        Employee e1 = new PermanentEmployee("Amit", 30000);
        Employee e2 = new ContractEmployee("Riya", 20000);

        e1.GenerateSalarySlip();
        e2.GenerateSalarySlip();
    }
}