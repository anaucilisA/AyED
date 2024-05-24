using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_silicuana_La_carrera_de_Homero
{
    class Program
    {
        static void Main(string[] args)
        {
            int obstaculos;
            String si = "si";
            String no = "no";
            String respuesta;
            String respuesta2;
            int puntos = 0;
            Console.Write("que obtaculos tiene que pasar homero para llegar al Bar = ");
            obstaculos = int.Parse(Console.ReadLine());
            int[] losObstaculos = new int[obstaculos];
            for (int i = 0; i < obstaculos; i++)
            {
                Console.WriteLine("Homero supera el Obstaculo " + (i + 1) + " si/no");
                respuesta = Console.ReadLine();
                if (respuesta == si)
                {
                    losObstaculos[i] = 10;
                }
                else if (respuesta == no)
                {
                    losObstaculos[i] = -5;
                }
                else if (!(respuesta == si || respuesta == no))
                {
                    Console.WriteLine("Homero supera el Obstaculo " + (i + 1) + " si/no ");
                    respuesta2 = Console.ReadLine();
                    if (respuesta2 == si)
                    {
                        losObstaculos[i] = 10;
                    }
                    else if (respuesta2 == no)
                    {
                        losObstaculos[i] = -5;
                    }

                }
                puntos = puntos + losObstaculos[i];

            }
            Console.WriteLine("homero gano " + puntos + " puntos y llego al Bar");

            
            Console.WriteLine("HOMERO FELIZ :D");
            


            //final ;)   :o
            Console.ReadKey();
        }
    }
}
