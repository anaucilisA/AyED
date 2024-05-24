using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_silicuana_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (num < 101)
            {
                if (!(num % 3 == 0 & num % 5 == 0))
                {
                    if (!(num % 5 == 0))
                    {
                        if (num % 3 == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("fizz");


                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine(num);
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("buzz");
                    }


                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("fizzbuzz");
                }

                num++;


            }
            Console.ReadKey();
        }
    }
}
