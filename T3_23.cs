using System;

abstract class Account
{
    protected double amount;

    public Account(double amount)
    {
        this.amount = amount;
    }

    public abstract void CalculateInterest();
}

class SavingAccount : Account
{
    public SavingAccount(double amount) : base(amount)
    {
    }

    public override void CalculateInterest()
    {
        Console.WriteLine("Saving Account Interest: " + (amount * 0.04));
    }
}

class FixedDeposit : Account
{
    public FixedDeposit(double amount) : base(amount)
    {
    }

    public override void CalculateInterest()
    {
        Console.WriteLine("Fixed Deposit Interest: " + (amount * 0.07));
    }
}

class T3_23
{
    static void Main()
    {
        Account a1 = new SavingAccount(10000);
        Account a2 = new FixedDeposit(10000);

        a1.CalculateInterest();
        a2.CalculateInterest();
    }
}