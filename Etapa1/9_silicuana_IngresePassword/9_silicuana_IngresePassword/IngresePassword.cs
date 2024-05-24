using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_silicuana_IngresePassword
{
    class Program
    {
        static void Main(string[] args)
        {
            string contra = "gato";
            string contraseña;
            Console.WriteLine("ingrese la contraseña");
            contraseña = Console.ReadLine();

            if (contraseña == contra)
            {
                Console.WriteLine("contraseña correcta");
            }
            else
            {
                Console.WriteLine("contraseña incorrecta");

            }
            Console.ReadKey();
        }
    }
}
