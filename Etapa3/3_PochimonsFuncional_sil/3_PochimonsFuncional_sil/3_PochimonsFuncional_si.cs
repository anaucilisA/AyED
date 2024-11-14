namespace _3_PochimonsFuncional_sil;

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> pochimones = new List<string>();
        int opcion;

        do
        {
            MostrarMenu();
            opcion = ObtenerOpcion();

            switch (opcion)
            {
                case 1:
                    CapturarPochimon(pochimones);
                    break;
                case 2:
                    VerPochimones(pochimones);
                    break;
                case 3:
                    LucharConPochimon(pochimones);
                    break;
                case 4:
                    Console.WriteLine("Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                    break;
            }
        } while (opcion != 4);
    }

    static void MostrarMenu()
    {
        Console.WriteLine("1. Capturar un Pochimon");
        Console.WriteLine("2. Ver Pochimones capturados");
        Console.WriteLine("3. Luchar con un Pochimon");
        Console.WriteLine("4. Salir");
    }

    static int ObtenerOpcion()
    {
        Console.Write("Selecciona una opción: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void CapturarPochimon(List<string> pochimones)
    {
        Console.Write("Introduce el nombre del Pochimon que deseas capturar: ");
        string nombre = Console.ReadLine();
        pochimones.Add(nombre);
        Console.WriteLine($"Pochimon '{nombre}' capturado con éxito!");
    }

    static void VerPochimones(List<string> pochimones)
    {
        if (pochimones.Count > 0)
        {
            Console.WriteLine("Pochimones capturados:");
            for (int i = 0; i < pochimones.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {pochimones[i]}");
            }
        }
        else
        {
            Console.WriteLine("No has capturado ningún Pochimon.");
        }
    }

    static void LucharConPochimon(List<string> pochimones)
    {
        if (pochimones.Count > 0)
        {
            VerPochimones(pochimones);
            Console.Write("Selecciona el número del Pochimon: ");
            int eleccion = Convert.ToInt32(Console.ReadLine()) - 1;

            if (eleccion >= 0 && eleccion < pochimones.Count)
            {
                Console.WriteLine($"Luchando con Pochimon '{pochimones[eleccion]}'!");
                // Aquí puedes implementar la lógica de lucha  
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }
        else
        {
            Console.WriteLine("No puedes luchar, no tienes Pochimones capturados.");
        }
    }
}
