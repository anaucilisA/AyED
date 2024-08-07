using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_silicuana_RotarMatriz90
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ramdom = new Random();

            Console.Write("ingrese el tamaño de las filas: ");
            int f = int.Parse(Console.ReadLine());
            Console.Write("ingrese el tamaño de las columnas: ");
            int c = int.Parse(Console.ReadLine());
            int[,] matriz = new int[f, c];
            int[,] matriz2 = new int[c, f];
            Console.WriteLine();
            Console.WriteLine("matriz normal");
            Console.WriteLine();
            for (int i = 0; i < f; i++)
            {
                for (int t = 0; t < c; t++)
                {
                    matriz[i, t] = ramdom.Next(1, 100);
                    matriz2[t, i] = matriz[i, t];
                    Console.Write(matriz[i, t] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("matriz rotada 90 grados");
            Console.WriteLine();
            for (int i = 0; i < c; i++)
            {
                for (int t = 0; t < f; t++)
                {

                    Console.Write(matriz[t, i] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
