
namespace _4_AMBDibuAAAventuras_sil;

using System;
namespace ABM_DibuAventuras
{
    class Program
    {
        static string[,] personajes = new string[20, 5];
        static int totalPersonajes = 0;

        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                MostrarMenu();
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        AgregarPersonaje();
                        break;
                    case 2:
                        BuscarPersonaje();
                        break;
                    case 3:
                        EditarPersonaje();
                        break;
                    case 4:
                        EliminarPersonaje();
                        break;
                    case 5:
                        MostrarListaDePersonajes();
                        Console.ReadLine();
                        break;
                    case 6:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida, intente nuevamente.");
                        break;
                }
            }
        }

        static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine($"Total de personajes: {totalPersonajes}/20");
            Console.WriteLine("---------------------------Menú--------------------");
            Console.WriteLine("1. Agregar Personaje");
            Console.WriteLine("2. Buscar Personaje");
            Console.WriteLine("3. Editar Personaje");
            Console.WriteLine("4. Eliminar Personaje");
            Console.WriteLine("5. Mostrar todos los personajes");
            Console.WriteLine("6. Salir");
            Console.WriteLine("---------------------------------------------------");
            Console.Write("Seleccione una opción: ");
        }

        static void AgregarPersonaje()
        {
            Console.Write("Ingrese el nombre del personaje: ");
            string nombrePersonaje = Console.ReadLine();
            Console.Write("Ingrese el nombre de la serie a la que pertenece: ");
            string nombreSerie = Console.ReadLine();
            Console.Write("Ingrese la cantidad de fuerza del personaje: ");
            int fuerza = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de defensa del personaje: ");
            int defensa = int.Parse(Console.ReadLine());
            Console.Write("Indique si su personaje es un héroe (true/false): ");
            bool esHeroe = bool.Parse(Console.ReadLine());

            personajes[totalPersonajes, 0] = nombrePersonaje;
            personajes[totalPersonajes, 1] = nombreSerie;
            personajes[totalPersonajes, 2] = fuerza.ToString();
            personajes[totalPersonajes, 3] = defensa.ToString();
            personajes[totalPersonajes, 4] = esHeroe.ToString();
            totalPersonajes++;
            Console.ReadLine();
        }

        static void BuscarPersonaje()
        {
            Console.Write("Ingrese el nombre del personaje que desea buscar: ");
            string nombreBuscado = Console.ReadLine();
            Console.WriteLine("Fila " + "\t" + "Nombre " + "\t" + "Serie " + "\t" + "Fuerza " + "\t" + "Defensa " + "\t" + "Héroe ");
            for (int i = 0; i < totalPersonajes; i++)
            {
                if (nombreBuscado.Equals(personajes[i, 0], StringComparison.OrdinalIgnoreCase))
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(personajes[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }

        static void MostrarListaDePersonajes()
        {
            Console.WriteLine("Fila " + "\t" + "Nombre " + "\t" + "Serie " + "\t" + "Fuerza " + "\t" + "Defensa " + "\t" + "Héroe ");
            for (int i = 0; i < totalPersonajes; i++)
            {
                Console.Write(i + "\t");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(personajes[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void EditarPersonaje()
        {
            MostrarListaDePersonajes();
            Console.WriteLine();
            Console.Write("Ingrese la fila del personaje que desea modificar: ");
            int filaModificar = int.Parse(Console.ReadLine());
            if (filaModificar < totalPersonajes)
            {
                Console.Write("Ingrese la nueva fuerza del personaje: ");
                int nuevaFuerza = int.Parse(Console.ReadLine());
                personajes[filaModificar, 2] = nuevaFuerza.ToString();
                Console.Write("Ingrese la nueva defensa del personaje: ");
                int nuevaDefensa = int.Parse(Console.ReadLine());
                personajes[filaModificar, 3] = nuevaDefensa.ToString();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("La fila no existe.");
            }
        }

        static void EliminarPersonaje()
        {
            MostrarListaDePersonajes();
            Console.Write("Ingrese la fila del personaje que desea eliminar: ");
            int filaEliminar = int.Parse(Console.ReadLine());

            if (filaEliminar < totalPersonajes && filaEliminar >= 0)
            {
                for (int i = filaEliminar; i < totalPersonajes - 1; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        personajes[i, j] = personajes[i + 1, j];
                    }
                }
                for (int j = 0; j < 5; j++)
                {
                    personajes[totalPersonajes - 1, j] = null;
                }

                totalPersonajes--;
                Console.WriteLine("Personaje fue eliminado con éxito.");
            }
            else
            {
                Console.WriteLine("Fila no válida.");
            }
            Console.ReadLine();
        }
    }
}

