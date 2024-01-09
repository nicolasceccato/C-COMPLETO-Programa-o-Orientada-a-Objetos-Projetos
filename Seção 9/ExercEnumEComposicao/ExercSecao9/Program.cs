using System;
using ExercSecao9.Entities;
using ExercSecao9.Entities.Enums;

namespace ExercSecao9 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (MM/MM/YYYY): ");
            DateTime birthDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("------------------------");
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int numberOfItems = Convert.ToInt32(Console.ReadLine());
            Product product = null;
            OrderItem orderItem = null;

            Client client = new Client(name, email, birthDate);
            Order order = new Order(os, client);

            for (int i = 1; i <= numberOfItems; i++)
            {
                Console.WriteLine($"Enter {i} item data: ");
                Console.Write($"Product name: ");
                string productName = Console.ReadLine();
                Console.Write($"Product price: ");
                double productPrice = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Quantity: ");
                int quantity = Convert.ToInt32(Console.ReadLine());
                product = new Product(productName, productPrice);
                orderItem = new OrderItem(quantity, productPrice, product);
                order.AddItem(orderItem);
            }

            Console.WriteLine(order);
        }
    }
}