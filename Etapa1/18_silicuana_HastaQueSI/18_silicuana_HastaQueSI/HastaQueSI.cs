using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_silicuana_HastaQueSI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool buc = true;
            string respuesta;
            string si = "SI";
            while (buc)
            {
                Console.WriteLine("diga SI para terminar");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Desea terminar el programa");
                respuesta = Console.ReadLine();

                if (respuesta == si)
                {
                    Console.WriteLine("precione cualquier tecla");
                    buc = false;
                }

            }
            //fin
            Console.ReadKey();
        }
    }
}
