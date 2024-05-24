using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_silicuana_ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("ingrese un numero");
            num = int.Parse(Console.ReadLine());
            if ((num % 2) == 0)
            {
                Console.WriteLine("el numero es par");
            }
            else
            {
                Console.WriteLine("el numero es impar");
            }
            Console.ReadKey();
        }
    }
}
