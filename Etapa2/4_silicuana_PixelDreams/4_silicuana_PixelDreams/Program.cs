using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_silicuana_PixelDreams
{
    class Program
    {
        static void Main(string[] args)
        {
            int jugadores;
            Console.Write("ingrese la cantidad de jugadores =  ");
            jugadores = int.Parse(Console.ReadLine());
            int[] losJugadores = new int[jugadores];
            bool bucle = true;
            int orden = 0;
            for (int i = 0; i < jugadores; i++)
            {
                
                Console.Write("ingrese el puntaje del jugador " + (i + 1) +" = ");
                int puntos = int.Parse(Console.ReadLine());
                losJugadores[i] = puntos;
            }
            for (int i = 0; i < jugadores - 1; i++)

            {
                for (int t = 0; t < jugadores - 1; t++)
                {
                    if (losJugadores[t] < losJugadores[t + 1])
                    {
                        orden = losJugadores[t + 1];
                        losJugadores[t + 1] = losJugadores[t];
                        losJugadores[t] = orden;
                    }
                }
            }
            Console.Clear();
            for (int i = 0; i < jugadores; i++)
            {
                Console.WriteLine(losJugadores[i]);
                Console.WriteLine("..........................");
            }
            Console.ReadKey();
        }
    }
}
