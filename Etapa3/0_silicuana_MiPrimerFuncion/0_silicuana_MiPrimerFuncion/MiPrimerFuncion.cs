using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_silicuana_MiPrimerFuncion
{
    class Program
    {
        static string nombre(string po)
        {
            string saludos = ("hola" + po);
            return saludos;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(nombre(" andy"));
            Console.ReadKey();
        }
    }
}
