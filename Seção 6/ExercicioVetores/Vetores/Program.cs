using System;
using Vetores.Model;

namespace Vetores // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            Rent[] rents = new Rent[10];


            for (int i = 0; i < numberOfStudents; i++)
            {
                string studentName = Console.ReadLine();
                string studentEmail = Console.ReadLine();
                int room = Convert.ToInt32(Console.ReadLine());
                rents[room] = new Rent { Name = studentName, Email = studentEmail };
            }

            for (int i = 0; i < 10; i++)
            {
                if (rents[i] != null)
                {
                    Console.WriteLine(i + ": " + rents[i]);
                }
            }
        }
    }
}