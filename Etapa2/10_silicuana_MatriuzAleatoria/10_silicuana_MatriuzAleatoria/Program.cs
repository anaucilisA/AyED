using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_silicuana_MatriuzAleatoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            Console.Write("ingrese las columnas = ");
            int co = int.Parse(Console.ReadLine());
            Console.Write("ingrese las filas  = ");
            int fi = int.Parse(Console.ReadLine());

            int[,] matriz = new int[fi, co];

            for (int f = 0; f < fi; f++)
            {
                for (int c = 0; c < co; c++)
                {
                    matriz[f,c] = aleatorio.Next(1,100);
                    Console.Write(matriz[f, c] + "\t");

                }
                Console.WriteLine("");
            }
            //fin
            Console.ReadKey();
            }
    }
}
