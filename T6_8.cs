
using System;

class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message)
        : base(message)
    {
    }
}

class BankAccount
{
    double balance = 5000;

    public void Withdraw(double amount)
    {
        if (amount > balance)
        {
            throw new InsufficientBalanceException(
                "Insufficient balance!");
        }

        if (amount <= 0)
        {
            throw new ArgumentException(
                "Amount must be positive.");
        }

        balance -= amount;
        Console.WriteLine("Withdrawal successful.");
        Console.WriteLine("Remaining Balance: " + balance);
    }
}

class T6_8
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        try
        {
            Console.Write("Enter withdrawal amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            account.Withdraw(amount);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid amount.");
        }
    }
}
