using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string name = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa:");
            int rooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] infos = Console.ReadLine().Split(" ");

            string lastName = infos[0];
            int age = int.Parse(infos[1]);
            double height = double.Parse(infos[2], CultureInfo.InvariantCulture);


            Console.WriteLine(name);
            Console.WriteLine(rooms);
            Console.WriteLine(price);
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height);
        }
    }
}