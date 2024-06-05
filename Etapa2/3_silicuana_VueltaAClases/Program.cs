using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_silicuana_VueltaAClases
{
    class Program
    {
        static void Main(string[] args)
        {
            int notafinal = 0;
            int aprobados = 0;
            int porcentaje = 0;
            int pruebas;
            int tp;
            int nota;

            Console.Write("ingrese la cantidad de pruebas ");
            pruebas = int.Parse(Console.ReadLine());
            Console.Write("ingrese la cantidad de tp ");
            tp = int.Parse(Console.ReadLine());
            int[] laspruebas = new int[pruebas];
            int[] tps = new int[tp];
            for (int i = 0; i < pruebas; i++)
            {
                Console.Write("ingrese las nota de la prueba" + (i + 1 ) + " = ");
               nota = int.Parse(Console.ReadLine());
                laspruebas[i] = nota;
            }
            for (int i = 0; i < pruebas; i++)
            {
                notafinal = notafinal + laspruebas[i];
            }
            for (int i = 0; i < tp; i++)
            {
                Console.Write("ingrese la nota del tp " + (i + 1 ) + " = ");
                nota = int.Parse(Console.ReadLine());
                tps[i] = nota;
                if (tps[i] >= 6)
                {
                    porcentaje++;
                }
            }
            aprobados = (int)(0.75*tp);
            if ((notafinal) >= 6 && porcentaje >= (aprobados))
            {
                Console.Write("aprobaron");
            }
            else
            {
                Console.Write("no puede aprobar");
            }
            Console.ReadKey();
            /*
           El promedio de las notas de los exámenes debe ser mayor o igual a 6.
             Al menos el 75% de los TPs deben tener una nota igual o mayor a 6.
             */
        }
    }
}
