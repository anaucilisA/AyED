using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_silicuana_CuentaRegresiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("dame un numero");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("_______________________");
            for (int i=0 ;i<num+1;i++)
            {
                Console.WriteLine(num - i);
            }
            Console.ReadKey();

        }
    }
}
