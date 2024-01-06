using System;

namespace Matrizes // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] size = Console.ReadLine().Split(' ');
            
            int m = Convert.ToInt32(size[0]);
            int n = Convert.ToInt32(size[1]);

            int[,] mat = new int[m,n];

            for(int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++) 
                {
                    mat[i, j] = Convert.ToInt32(values[j]);
                }
            }

            int search = Convert.ToInt32(Console.ReadLine());

            for(int i = 0;i < m; i++) 
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == search)
                    {
                        Console.WriteLine("Position " + i + ", " + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }




        }
    }
}