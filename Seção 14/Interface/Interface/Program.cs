using System;
using System.Globalization;
using Interface.Entities;
using Interface.Services;

namespace Interface;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter contract data:");
        Console.Write("Number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Date (dd/MM/yyyy): ");
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        Console.Write("Contract value: ");
        double contractValue = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter number of installments: ");
        int numberOfInstallments = Convert.ToInt32(Console.ReadLine());

        Contract contract = new Contract(number, date, contractValue);
        ContractService contractService = new ContractService(new Paypal());
        contractService.ProcessContract(contract, numberOfInstallments);

        Console.WriteLine("Installments: ");

        foreach (Installments installment in contract.InstallmentsList)
        {
            Console.WriteLine(installment);
        }
    }
}