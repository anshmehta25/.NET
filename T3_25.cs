using System;

class T3_25
{
    static void Main()
    {
        string password = "  admin123  ";

        password = password.Trim();

        Console.WriteLine("Password Length: " + password.Length);
        Console.WriteLine("Uppercase Password: " + password.ToUpper());
        Console.WriteLine("Contains 123: " + password.Contains("123"));

        string newPassword = password.Replace("admin", "user");
        Console.WriteLine("Modified Password: " + newPassword);
    }
}