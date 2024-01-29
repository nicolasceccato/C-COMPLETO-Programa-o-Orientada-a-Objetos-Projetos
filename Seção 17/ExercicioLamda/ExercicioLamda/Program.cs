using System;
using System.Globalization;
using ExercicioLamda.Models;

namespace ExercicioLamda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listOfEmployees = new List<Employee>();

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter salary: ");
            double targetSalary = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] employeeLine = sr.ReadLine().Split(",");
                        string employeeName = employeeLine[0];
                        string employeeEmail = employeeLine[1];
                        double employeeSalary = double.Parse(employeeLine[2], CultureInfo.InvariantCulture);

                        listOfEmployees.Add(new Employee(employeeName, employeeEmail, employeeSalary));
                    }

                    var employeesWhoEarnMoreThanTarget = listOfEmployees
                        .Where(p => p.Salary > targetSalary)
                        .OrderBy(p => p.Email)
                        .Select(p => p.Email);


                    Console.WriteLine(
                        $"Email of people whose salary is more than {targetSalary.ToString("F2", CultureInfo.InvariantCulture)}");
                    foreach (string employee in employeesWhoEarnMoreThanTarget)
                    {
                        Console.WriteLine(employee);
                    }

                    var sum = listOfEmployees
                        .Where(p => p.Name[0] == 'M')
                        .Select(p => p.Salary)
                        .DefaultIfEmpty(0.0)
                        .Sum();

                    Console.WriteLine(
                        $"Sum of salary of people whose name starts with 'M': {sum.ToString("F2", CultureInfo.InvariantCulture)}");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}