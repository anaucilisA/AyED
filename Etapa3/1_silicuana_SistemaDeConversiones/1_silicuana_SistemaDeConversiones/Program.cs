using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_silicuana_SistemaDeConversiones
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int num = 10;
            int tamaño = 4;
            int[] numero = { 0, 1, 0, 0 };
            Console.WriteLine("numero " + num + " en binario: ");
            Console.Write((numeroBinario(num)));
            Console.WriteLine(" numero " + string.Join("", numero) + " en decimal: " + (numeroDecimal(0, tamaño, numero)));

            Console.ReadKey();
        }
        static int numeroBinario(int numero)
        {
            if (numero > 0)
            {
                String lista = "";
                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        lista = "0" + lista;
                    }
                    else
                    {
                        lista = "1" + lista;
                    }
                    numero = (int)(numero / 2);
                }
                Console.WriteLine(lista);
            }
            return numero;
        }
        static int numeroDecimal(int puntos, int tam, int[] losNumeros)
        {
            for (int i = 0; i < tam; i++)
            {
                puntos += losNumeros[i] * (int)Math.Pow(4, 1);
            }

            return puntos;
        }
    }
}

        