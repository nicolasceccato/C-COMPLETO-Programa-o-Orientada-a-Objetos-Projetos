using Listas.Model;
using System;

namespace Listas // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int numberOfEmployees = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine("Employee #" + (i+1) + ":");
                
                Console.Write("Id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());

                employees.Add(new Employee(id, name, salary));

            }

            Console.Write("Enter the employee that will have salary increase: ");
            int increaseId = Convert.ToInt32(Console.ReadLine());

            bool idExist = employees.Any(x => x.Id == increaseId);

            
            if (idExist)
            {

                Console.Write("Enter the porcentage: ");
                double increasePorcentage = Convert.ToDouble(Console.ReadLine());
                Employee employee = employees.Find(x => x.Id == increaseId);
                employee.increaseSalary(increasePorcentage);
            
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            
            Console.WriteLine("Updated list of employees:");
            foreach(Employee e in employees)
            {
                Console.WriteLine(e);
            }
        }
    }
}