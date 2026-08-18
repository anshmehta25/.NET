using System;

class BankAccount
{
    private int accountNo;
    private string holderName;
    private double balance;

    public BankAccount(int accountNo, string holderName, double balance)
    {
        this.accountNo = accountNo;
        this.holderName = holderName;
        this.balance = balance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
            balance -= amount;
        else
            Console.WriteLine("Insufficient balance");
    }

    public void DisplayBalance()
    {
        Console.WriteLine(holderName + " Balance: " + balance);
    }
}

class T3_11
{
    static void Main()
    {
        BankAccount a1 = new BankAccount(101, "Amit", 5000);
        BankAccount a2 = new BankAccount(102, "Neha", 8000);

        a1.Deposit(1000);
        a2.Withdraw(2000);

        a1.DisplayBalance();
        a2.DisplayBalance();
    }
}