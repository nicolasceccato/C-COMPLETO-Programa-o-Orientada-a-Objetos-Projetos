using System;
using System.Globalization;

namespace ConsoleApp1.Model
{
    public class Account
    {
        public int AccountNumber { get; }
        public string Name { get; set; }
        public double Balance { get; private set; }

        public Account(int accountNumber, string name)
        {
            AccountNumber = accountNumber;
            Name = name;
            Balance = 0.0;
        }
        public Account(int accountNumber, string name, double value) : this(accountNumber, name)
        {
            Deposit(value);
        }


        public void Deposit(double value)
        {
            if (value != null && value > 0)
            {
                Balance += value;
            }
        }
        public void Withdraw(double value)
        {
            if (value != null && value > 0)
            {
                Balance = Balance - value - 5.00;
            }
        }

        public override string ToString()
        {
            return "Conta: " + AccountNumber + ", Titular: " + Name + ", Saldo: $" + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
