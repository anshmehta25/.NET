using System;

class Employee
{
    int empCode;
    string name, designation;
    double basicPay;

    public Employee(int code, string n, string d, double basic)
    {
        empCode = code;
        name = n;
        designation = d;
        basicPay = basic;
    }

    public void CalculatePay()
    {
        double hra = basicPay * 0.10;
        double da = basicPay * 0.45;
        double total = basicPay + hra + da;

        Console.WriteLine("Employee Code: " + empCode);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Designation: " + designation);
        Console.WriteLine("Basic Pay: " + basicPay);
        Console.WriteLine("HRA: " + hra);
        Console.WriteLine("DA: " + da);
        Console.WriteLine("Total Pay: " + total);
        Console.WriteLine();
    }
}

class T4_1
{
    static void Main()
    {
        Employee e1 = new Employee(101, "Ansh", "Manager", 30000);
        Employee e2 = new Employee(102, "Rahul", "Developer", 40000);
        Employee e3 = new Employee(103, "Amit", "Tester", 25000);

        e1.CalculatePay();
        e2.CalculatePay();
        e3.CalculatePay();
    }
}