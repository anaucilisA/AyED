using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Silicuana_DimensionesDeEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            int radio;
            float pi;
            Console.WriteLine("introduce un numero para el radio de la esfera");
            radio = int.Parse(Console.ReadLine());
            pi = 3.14f;
            Console.WriteLine("la supericie de la esfera es " + (4 * pi * radio * radio));
            Console.WriteLine("el volumen de la esfera es " + ((3 * pi * radio * radio * radio) / 4));
            Console.ReadKey();
        }
    }
}
