using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_silicuana_AreaVolumen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el radio del circulo");
            int radio = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el alto del cilindro");
            int altura = int.Parse(Console.ReadLine());
            Console.WriteLine("el area del circulo es = " + Acirculo(radio));
            Console.WriteLine("el radio del cilindro es =" + Vcilindro(radio,altura));
            Console.ReadKey();
        }
        static double Acirculo(double r)
        {
            r = Math.PI * r;
            return r;
        }
        static double Vcilindro(double volumen , int h)
        {
            volumen = Math.PI + (volumen * volumen * h);
            return volumen;
        }
    }
}
