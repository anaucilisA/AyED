using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_silicuana_ValorDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;
            int ancho;
            Console.WriteLine("dame una altura");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine("dame un ancho");
            ancho = int.Parse(Console.ReadLine());
            Console.WriteLine("el perimetro del rectangulo es " + (ancho * 2 + altura * 2));
            Console.WriteLine("el area del rectangulo es " + (ancho * altura));
            Console.WriteLine("la diagonal del triangulo es " + Math.Sqrt((ancho * ancho + altura * altura)));
            Console.ReadKey();
        }
    }
}
