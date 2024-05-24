using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Silicuana_HastaN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cuantos años tenes");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            int edad2 = edad + edad;
            int num = 1;
            while (edad < edad2)
            {
                Console.WriteLine(((edad2 - edad - (edad - num)))/2);
                edad2--;
                num = num + 2;
            }
            Console.ReadKey();
        }
    }
}
