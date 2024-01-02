using ConsoleApp1.Model;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int accountNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string accountOwner = Console.ReadLine();
            Console.Write("Haverá depósito inicial?(S/N) ");
            char initialDeposit = Convert.ToChar(Console.ReadLine().ToUpper());
            Account account = null;

            if (initialDeposit == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double accountInitialDeposit = Convert.ToDouble(Console.ReadLine());
                account = new Account(accountNumber, accountOwner, accountInitialDeposit);
            }
            else
            {
                account = new Account(accountNumber, accountOwner);
            }

            Console.Write("Entre um valor para depósito: ");
            double deposit = Convert.ToDouble(Console.ReadLine());
            account.Deposit(deposit);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(account);


            Console.Write("Entre um valor para saque: ");
            double draw = Convert.ToDouble(Console.ReadLine());
            account.Withdraw(draw);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(account);


        }
    }
}