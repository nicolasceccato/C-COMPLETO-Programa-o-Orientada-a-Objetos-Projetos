using System;
using MetodosAbstratos.Entities;

namespace MetodosAbstratos // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            List<TaxPayer> listOfTaxPayers = new List<TaxPayer>();
            int numberOfTaxPayers = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= numberOfTaxPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c): ");
                char typeOfPayer = Convert.ToChar(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = Convert.ToDouble(Console.ReadLine());
                if (typeOfPayer == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = Convert.ToDouble(Console.ReadLine());
                    listOfTaxPayers.Add(new Person(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = Convert.ToInt32(Console.ReadLine());
                    listOfTaxPayers.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            double totalTaxes = 0;
            foreach (TaxPayer taxPayer in listOfTaxPayers)
            {
                totalTaxes += taxPayer.TotalToPay();
                Console.WriteLine(taxPayer.Name + ": $ " + taxPayer.TotalToPay().ToString("F2"));
            }

            Console.WriteLine();
            Console.Write("TOTAL TAXES: " + totalTaxes);
        }
    }
}