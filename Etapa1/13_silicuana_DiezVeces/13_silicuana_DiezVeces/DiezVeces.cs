using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_silicuana_DiezVeces
{
    class Program
    {
        static void Main(string[] args)
        {
            String palabra;
            Console.WriteLine("ingrese na palabra");
            palabra = Console.ReadLine();
            Console.WriteLine("-----------------------------");

            int contador;
            contador = 0;

            while ( contador < 10)
            {
                Console.WriteLine(palabra);
                contador++;
            }
            Console.ReadKey();

        }
    }
}
