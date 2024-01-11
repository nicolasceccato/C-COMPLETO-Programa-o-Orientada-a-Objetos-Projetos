using Exceptions.Entities;
using Exceptions.Entities.ProgramExceptions;

namespace Exceptions;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter account data:");
            Console.Write("Number: ");
            int accountNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial Balance: ");
            double initialBalance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Withdraw limit: ");
            double withdrawLimit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the amount for withdraw: ");
            double amountForWithdraw = Convert.ToDouble(Console.ReadLine());

            Account account = new Account(accountNumber, holder, initialBalance, withdrawLimit);

            account.WithDraw(amountForWithdraw);
            Console.Write("New balance: " + account.Balance);
        }
        catch (DomainException e)
        {
            Console.WriteLine("Error in withdraw: " + e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Error with your data: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}