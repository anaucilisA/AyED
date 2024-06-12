using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_silicuana_ZEGARPG
{
    class Program
    {
        static void Main(string[] args)
        {
            int objetos;
            int valorM;
            Console.Write(" ingrese la cantidad de objetos = ");
            objetos = int.Parse(Console.ReadLine());
            int[] losObjetos = new int[objetos];
            Console.Write(" ingrese el valor minimo de los objetos = ");
            valorM = int.Parse(Console.ReadLine());
            Console.WriteLine(".....................");
            for (int i = 0; i < objetos; i++)
            {
                Console.WriteLine("ingresa el valor minimo del obejeto " + (i + 1));
                int valor = int.Parse(Console.ReadLine());
                losObjetos[i] = valor;
            }
            Console.WriteLine(".....................");
            Console.WriteLine("objetos que superan al valor minimo:");
            for (int i = 0; i < objetos; i++)
            {
                if (losObjetos[i] > valorM)
                {
                    Console.WriteLine("objeto " + (i + 1));
                }
            }
            Console.WriteLine("objetos que no  superan al valor minimo:");
            for (int i = 0; i < objetos; i++)
            { 
                if (losObjetos[i] < valorM)
                {
                    Console.WriteLine("objeto " + (i + 1));
                }
        }
        //final

        Console.ReadKey();
        }
    }
}
