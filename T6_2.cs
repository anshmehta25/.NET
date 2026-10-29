
using System;

interface IPersonalDetails
{
    void DisplayPersonal();
}

interface IProfessionalDetails
{
    void DisplayProfessional();
}

class Employee : IPersonalDetails, IProfessionalDetails
{
    public void DisplayPersonal()
    {
        Console.WriteLine("Name: Rahul");
        Console.WriteLine("Age: 22");
        Console.WriteLine("City: Rajkot");
    }

    public void DisplayProfessional()
    {
        Console.WriteLine("Employee ID: 101");
        Console.WriteLine("Department: IT");
        Console.WriteLine("Salary: 30000");
    }
}

class Program
{
    static void Main()
    {
        Employee e = new Employee();

        Console.WriteLine("Personal Details");
        e.DisplayPersonal();

        Console.WriteLine("\nProfessional Details");
        e.DisplayProfessional();
    }
}
