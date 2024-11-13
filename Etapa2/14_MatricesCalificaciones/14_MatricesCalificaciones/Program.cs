namespace _14_MatricesCalificaciones;

    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una matriz Nx3 donde cada fila representa un estudiante y cada columna contiene información como el nombre, la edad y la calificación.
            int edad, calificacion;
            string nombre;
            Console.Write("Ingrese el número de estudiantes: ");
            int n = int.Parse(Console.ReadLine());


            string[,] MatrizEstudiantes = new string[n, 3];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Ingrese los datos del estudiante {i + 1}:");

                Console.Write("Nombre: ");
                MatrizEstudiantes[i, 0] = Console.ReadLine();

                Console.Write("Edad: ");
                MatrizEstudiantes[i, 1] = Console.ReadLine();
                Console.Write("Calificación: ");
                MatrizEstudiantes[i, 2] = Console.ReadLine();
            }
            Console.WriteLine("\nInformación de los estudiantes:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Estudiante {i + 1}:");
                Console.WriteLine($"Nombre: {MatrizEstudiantes[i, 0]}");
                Console.WriteLine($"Edad: {MatrizEstudiantes[i, 1]}");
                Console.WriteLine($"Calificación: {MatrizEstudiantes[i, 2]}");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }

    

