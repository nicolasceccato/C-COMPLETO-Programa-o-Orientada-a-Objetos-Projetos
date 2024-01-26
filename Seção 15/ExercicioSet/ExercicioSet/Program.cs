using System;

namespace ExercicioSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> students = new HashSet<int>();

            Console.WriteLine("How many students for course A?");
            int numberA = Convert.ToInt32(Console.ReadLine());
            addStudent(students, numberA);

            Console.WriteLine("How many students for course B?");
            int numberB = Convert.ToInt32(Console.ReadLine());
            addStudent(students, numberB);

            Console.WriteLine("How many students for course C?");
            int numberC = Convert.ToInt32(Console.ReadLine());
            addStudent(students, numberC);

            Console.WriteLine("Total students: " + students.Count);
        }

        static void addStudent(HashSet<int> students, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                int studentId = Convert.ToInt32(Console.ReadLine());
                students.Add(studentId);
            }
        }
    }
}