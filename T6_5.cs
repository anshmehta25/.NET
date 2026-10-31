using System;

class BankAccount
{
    public event Action<double> MoneyDeposited;

    double balance = 1000;

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Enter a valid deposit amount.");
            return;
        }

        balance += amount;
        MoneyDeposited?.Invoke(amount);
    }

    public double GetBalance()
    {
        return balance;
    }
}

class T6_5
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        account.MoneyDeposited += amount =>
            Console.WriteLine("Deposited: " + amount);

        account.Deposit(500);

        Console.WriteLine("Current Balance: " +
                          account.GetBalance());
    }
}