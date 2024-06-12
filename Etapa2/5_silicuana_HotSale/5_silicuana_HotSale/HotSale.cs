using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_silicuana_HotSale
{
    class Program
    {
        static void Main(string[] args)
        {
            int productos;
            Console.Write(" ingrese la cantidad de productos vendidos = ");
            productos = int.Parse(Console.ReadLine());
            int[] losProductos = new int[productos];
            int orden = 0;
            for (int i = 0; i < productos; i++)
            { 
                Console.WriteLine("ingrese el precio del producto " + (i + 1));
                int puntos = int.Parse(Console.ReadLine());
                losProductos[i] = puntos;
            }
            for (int i = 0; i < productos - 1; i++)

            {
                for (int t = 0; t < productos - 1; t++)
                {
                    if (losProductos[t] < losProductos[t + 1])
                    {
                        orden = losProductos[t + 1];
                        losProductos[t + 1] = losProductos[t];
                        losProductos[t] = orden;
                    }
                }
            }
            Console.WriteLine("el precio mas alto es = " + losProductos[0]);
            Console.WriteLine("el precio mas bajo es = " + losProductos[productos - 1]);
            for (int i = 0; i < productos; i++)
            {
                Console.WriteLine("...........................");
                Console.WriteLine(losProductos[i]);
            }
            Console.ReadKey();
        }
    }
}
