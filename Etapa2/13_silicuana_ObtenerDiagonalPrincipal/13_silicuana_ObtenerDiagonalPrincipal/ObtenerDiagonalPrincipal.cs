using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_silicuana_ObtenerDiagonalPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;


            int[,] matriz = new int[n, n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = random.Next(1, 10);
                }
            }


            Console.WriteLine("Matriz generada:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }


            int[] diagonalPrincipal = new int[n];
            for (int i = 0; i < n; i++)
            {
                diagonalPrincipal[i] = matriz[i, i];
            }


            Console.WriteLine("\nDiagonal Principal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(diagonalPrincipal[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
  
