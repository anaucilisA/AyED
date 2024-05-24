using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_silicuana_ElRayoCarerraVelo
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 0;
            
            Console.WriteLine("cuantas vueltas hizo el rayo ");
            int[] vueltas = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < vueltas.Count(); i++)
            {
                Console.Write("en cuanto hizo la vuelta" + (i + 1) + " = " );
                t = int.Parse(Console.ReadLine());
                vueltas[i] = t;

            }
            t = 0;
            for (int i = 0; i < vueltas.Count(); i++)
            {
                t = vueltas[i] + t;
            }
            Console.WriteLine("el promedio de vueltas es " + t / vueltas.Count());
            t = vueltas[0];
            for (int i = 0; i < vueltas.Count(); i++)
            {
                if (t > vueltas[i])
                {
                    t = vueltas[i];
                }
            }
            Console.WriteLine("el mejor promedio es : " + t);
            

            



           
            //final
            Console.ReadKey();
        }
    }
}
