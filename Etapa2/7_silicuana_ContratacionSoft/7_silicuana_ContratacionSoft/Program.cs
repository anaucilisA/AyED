﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_silicuana_ContratacionSoft
{
    class Program
    {
        static void Main(string[] args)
        {
            int candidatos;
            int orden = 0;
            int entero;
            Console.Write(" ingrese la cantidad de candidatos = ");
            candidatos = int.Parse(Console.ReadLine());
            int[] losCandidatos = new int[candidatos];
            Console.WriteLine(".....................");
            for (int i = 0; i < candidatos; i++)
            {
                Console.WriteLine("ingresa el puntaje del candidato " + (i + 1));
                int valor = int.Parse(Console.ReadLine());
                losCandidatos[i] = valor;
            }
            for (int i = 0; i < candidatos - 1; i++)

            {
                for (int t = 0; t < candidatos - 1; t++)
                {
                    if (losCandidatos[t] > losCandidatos[t + 1])
                    {
                        orden = losCandidatos[t + 1];
                        losCandidatos[t + 1] = losCandidatos[t];
                        losCandidatos[t] = orden;
                    }
                }
            }
            Console.WriteLine(".......................");
            Console.WriteLine("lista con los puntajes ordenados ");
            for (int i = 0; i < candidatos; i++)
            {
                Console.WriteLine(losCandidatos[i]);
            }
            Console.WriteLine("..........................");
            Console.Write("ingrese un numero entero = ");
            entero = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------");
            Console.WriteLine("Puntajes que son multiplos = ");
            for (int i = 0; i < candidatos; i++)
            {
                if (losCandidatos[i] % entero == 0)
                {
                    Console.WriteLine(losCandidatos[i]);
                }
            }
            //final

            Console.ReadKey();
        }
    }
}
