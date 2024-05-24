using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_silicuana_MiPrimerMenuObjetivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola bienvenido,elija una de estas 3 opciones");
            bool buc = true;
            while (buc)
            {
                //variables menu
                int num1 = 1;
                int num2 = 2;
                int num3 = 3;
                int num4 = 4;
                //variables suma
                int numero1;
                int numero2;
                //variable saludos
                string hola;
                //variables tabla multi
                int numero;

               
                

                
                Console.WriteLine(num1 + " suma");
                Console.WriteLine(num2 + " saludos");
                Console.WriteLine(num3 + " multiplicacion");
                Console.WriteLine(num4 + " salir");
                Console.WriteLine("-------------------------");

                int opcion = int.Parse(Console.ReadLine());
                
                if (opcion == num1)
                {
                    Console.Clear();
                    
                    Console.WriteLine("ingrese dos numeros");
                    numero1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("+");
                    numero2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(numero1 + " + " + numero2 + " = " + (numero1 + numero2));
                    Console.WriteLine("ingrse una nueva opcion");
                }
                else if (opcion == num2) 
                {
                   Console.Clear();
                    
                    Console.WriteLine("ingrese su nombre");
                    hola = Console.ReadLine();
                    Console.WriteLine("hola " + hola);
                    Console.WriteLine("ingrese una nueva opcion");


                } 
                else if (opcion == num3)
                {
                    Console.Clear();
                    
                    Console.WriteLine("ingrese un número:");
                    numero = int.Parse(Console.ReadLine());
                    Console.WriteLine(numero + (" x 1 = ") + (numero * 1));
                    Console.WriteLine(numero + (" x 2 = ") + (numero * 2));
                    Console.WriteLine(numero + (" x 3 = ") + (numero * 3));
                    Console.WriteLine(numero + (" x 4 = ") + (numero * 4));
                    Console.WriteLine(numero + (" x 5 = ") + (numero * 5));
                    Console.WriteLine(numero + (" x 6 = ") + (numero * 6));
                    Console.WriteLine(numero + (" x 7 = ") + (numero * 7));
                    Console.WriteLine(numero + (" x 8 = ") + (numero * 8));
                    Console.WriteLine(numero + (" x 9 = ") + (numero * 9));
                    Console.WriteLine(numero + (" x 10 = ") + (numero * 10));
                    Console.WriteLine("ingrese una nueva opcion");

                }
                else if ( opcion == num4)
                {
                    buc = false;
                    Console.Clear();

                }
            }










            //finish
            Console.ReadKey();
        }
    }
}
