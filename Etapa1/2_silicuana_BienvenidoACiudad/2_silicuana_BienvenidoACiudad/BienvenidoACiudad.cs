using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_silicuana_BienvenidoACiudad
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string ciudad;

            Console.WriteLine("introduce tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("introduce el nombre de una ciudad");
            ciudad = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + " bienvenido " + ciudad);
            Console.ReadKey();
        }
    }
}
