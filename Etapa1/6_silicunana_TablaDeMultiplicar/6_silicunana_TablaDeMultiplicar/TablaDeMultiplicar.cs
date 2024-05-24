using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_silicunana_TablaDeMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("ingrese un número:");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Su tabla es : " + (numero * 1));
            Console.WriteLine("Su tabla es : " + (numero * 2));
            Console.WriteLine("Su tabla es : " + (numero * 3));
            Console.WriteLine("Su tabla es : " + (numero * 4));
            Console.WriteLine("Su tabla es : " + (numero * 5));
            Console.WriteLine("Su tabla es : " + (numero * 6));
            Console.WriteLine("Su tabla es : " + (numero * 7));
            Console.WriteLine("Su tabla es : " + (numero * 8));
            Console.WriteLine("Su tabla es : " + (numero * 9));
            Console.WriteLine("Su tabla es : " + (numero * 10));

            Console.ReadKey();
        }
    }
}
