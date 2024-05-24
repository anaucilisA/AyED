using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_silicuana_LaFiestaDeStitc
{
    class Program
    {
        static void Main(string[] args)
        {
            int ci;
            bool bucle = true;
            int cantidad;
            Console.Write("ingresa la cantida de invitados ");
            ci = int.Parse(Console.ReadLine());
            int[] inv = new int[ci];
            int cc = 0;
            for (int i = 0; i < ci; i++)
            {
                while (bucle)
                {
                    Console.WriteLine("cuanta comida consume el invitado " + (i + 1) + " (del 1 al 100)");
                    cantidad = int.Parse(Console.ReadLine());
                    if(cantidad < 1||cantidad>100)
                    {
                        bucle = true;
                        Console.WriteLine("por favor entre 1 y 100");
                    }
                    else if (cantidad > 1||cantidad<100)
                    {
                        bucle = false;
                        inv[i] = cantidad;
                    }
                   
                }
                bucle = true;
                cc = cc + inv[i];
            }
            Console.WriteLine("el promedio es "+ (cc/ci));
            Console.ReadKey();

        }

    }
}
