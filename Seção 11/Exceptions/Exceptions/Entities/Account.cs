using Exceptions.Entities.ProgramExceptions;

namespace Exceptions.Entities;

public class Account
{
    public int Number { get; set; }
    public string Holder { get; set; }
    public double Balance { get; set; }
    public double WithdrawLimit { get; set; }

    public Account(int number, string holder, double balance, double withdrawLimit)
    {
        Number = number;
        Holder = holder;
        Balance = balance;
        WithdrawLimit = withdrawLimit;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public void WithDraw(double amount)
    {
        if (amount > WithdrawLimit)
        {
            throw new DomainException("The amount exceed your limit!");
        }

        if (amount > Balance)
        {
            throw new DomainException("Insuficient Balance in your account!");
        }

        Balance = Balance - amount;
    }
}