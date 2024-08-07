using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_silicuana_VectorRandomSwith
{
    class Program
    {
        static void Main(string[] args)
        {
            bool pecausa = true;
            while (pecausa)
            {
                Console.Write("Ingrese el tamaño del vector:");
                int tamaño = int.Parse(Console.ReadLine());
                int[] losVector = new int[tamaño];
                Random aleatorio = new Random();
                for (int i = 0; i < tamaño; i++)
                {
                    int numers = aleatorio.Next(1, 50);
                    losVector[i] = numers;
                }

                int opcion;
                do
                {
                    Console.WriteLine(".-.-.-.-.-.-.-.Menu.-.-.-.-.-.-.-.");
                    Console.WriteLine("Opcion 1");
                    Console.WriteLine("Mostrar elementos del vector.");
                    Console.WriteLine("");
                    Console.WriteLine("Opcion 2");
                    Console.WriteLine("Buscar un numero en el vector.");
                    Console.WriteLine("");
                    Console.WriteLine("Opcion 3");
                    Console.WriteLine("Ordenar vector.");
                    Console.WriteLine("");
                    Console.WriteLine("Opcion 4");
                    Console.WriteLine("THE END :D.");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Elija una opcion");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            for (int i = 0; i < tamaño; i++)
                            {
                                Console.WriteLine("Vector " + i + " " + losVector[i]);
                            }
                            break;

                        case 2:
                            Console.WriteLine("Por favor, ingrese un número:");
                            int num = int.Parse(Console.ReadLine());
                            bool encontrado = false;
                            for (int i = 0; i < tamaño; i++)
                            {
                                if (num == losVector[i])
                                {
                                    Console.WriteLine("El número " + num + " se encuentra en la posición " + (i + 1));
                                    encontrado = true;
                                    break;
                                }
                            }
                            if (!encontrado)
                            {
                                Console.WriteLine("El número " + num + " no se encuentra en la lista.");
                            }
                            break;

                        case 3:
                            bool bucle = true;
                            string respuesta1 = "ascendente";
                            string respuesta2 = "descendente";
                            while (bucle)
                            {
                                Console.WriteLine("De qué forma quiere que se ordene el vector? (ascendente o descendente , de alla pa aca)");
                                string respuesta = Console.ReadLine();
                                if (respuesta == respuesta1)
                                {
                                    bucle = false;
                                    Array.Sort(losVector);
                                    for (int i = 0; i < tamaño; i++)
                                    {
                                        Console.WriteLine(losVector[i]);
                                    }
                                }
                                else if (respuesta == respuesta2)
                                {
                                    bucle = false;
                                    Array.Sort(losVector);
                                    Array.Reverse(losVector);
                                    for (int i = 0; i < tamaño; i++)
                                    {
                                        Console.WriteLine(losVector[i]);
                                    }
                                }
                                else
                                {
                                    bucle = true;
                                }
                            }
                            break;

                        case 4:
                            Console.WriteLine("Fin del programa.");
                            pecausa = false;
                            break;

                        default:
                            Console.WriteLine("Opción inválida. Por favor, elija una opción válida.");
                            break;
                    }

                } while (opcion != 4);

                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            }
        }
    }

}
    

