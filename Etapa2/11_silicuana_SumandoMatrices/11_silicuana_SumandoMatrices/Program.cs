using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_silicuana_SumandoMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ramdom = new Random();
            Console.Write("ingresa la cantidad de filas: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("ingresa la cantidad de columnas: ");
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, m];
            int[,] matrix2 = new int[n, m];
            int[,] matrix3 = new int[n, m];
            Console.WriteLine("Matriz 1: ");
            Console.WriteLine("");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = ramdom.Next(1, 100);
                    matrix2[i, j] = ramdom.Next(1, 100);
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("Matriz 2:");
            Console.WriteLine("");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix2[i, j] + "\t");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("suma de los dos matricez:");
            Console.WriteLine("");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix3[i, j] = matrix[i, j] + matrix2[i, j];
                    Console.Write(matrix3[i, j] + "\t");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
