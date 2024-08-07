using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_silicuana_MiPrimerMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese las colubnas = ");
            int co = int.Parse(Console.ReadLine());
            Console.Write("ingrese las filas  = ");
            int fi = int.Parse(Console.ReadLine());

            int[,] matriz = new int[fi,co];

            for (int f = 0; f < fi; f++)
            {
                for (int c = 0; c < co ;c++)
                {
                    Console.Write(matriz[f, c] + "\t");
                    
                }
                Console.WriteLine("");
            }











            //fin
            Console.ReadKey();
        }


    }
}
