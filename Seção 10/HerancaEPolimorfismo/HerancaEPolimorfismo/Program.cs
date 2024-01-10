using System;
using HerancaEPolimorfismo.Entities;

namespace HerancaEPolimorfismo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int numberOfProducts = Convert.ToInt32(Console.ReadLine());

            List<Product> listOfProducts = new List<Product>();

            for (int i = 1; i <= numberOfProducts; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Commom, used or imported (c/u/i): ");
                char typeOfProduct = Convert.ToChar(Console.ReadLine().ToUpper());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                if (typeOfProduct == 'C')
                {
                    listOfProducts.Add(new Product(name, price));
                }
                else if (typeOfProduct == 'U')
                {
                    Console.Write("Manufature date: ");
                    DateTime manufactureDate = Convert.ToDateTime(Console.ReadLine());
                    listOfProducts.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double customsFee = Convert.ToDouble(Console.ReadLine());
                    listOfProducts.Add(new ImportedProduct(name, price, customsFee));
                }
            }

            foreach (Product product in listOfProducts)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}