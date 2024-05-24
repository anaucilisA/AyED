using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_silicuana_EsDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            float num;
            float num2;
            Console.WriteLine("ingresa dos numeros");
            num = float.Parse(Console.ReadLine());
            num2 = float.Parse(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                Console.WriteLine(num + " /" + num2 + " = " + (num / num2));
            }
            Console.ReadKey();
        }
    }
}
