using InformacionEstudiantes;

public class Program
{
    static Estudiante[] estudiantes = new Estudiante[100];
    static int contador = 0;

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n--- Menú de Gestión de Estudiantes ---");
            Console.WriteLine("1. Agregar estudiante");
            Console.WriteLine("2. Modificar estudiante");
            Console.WriteLine("3. Eliminar estudiante");
            Console.WriteLine("4. Buscar estudiante");
            Console.WriteLine("5. Mostrar todos");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: AgregarEstudiante(); break;
                case 2: ModificarEstudiante(); break;
                case 3: EliminarEstudiante(); break;
                case 4: BuscarEstudiante(); break;
                case 5: MostrarTodos(); break;
                case 6: Console.WriteLine("Saliendo..."); break;
                default: Console.WriteLine("Opción no válida."); break;
            }

        } while (opcion != 6);
    }

    static void AgregarEstudiante()
    {
        if (contador >= estudiantes.Length)
        {
            Console.WriteLine("No se pueden agregar más estudiantes.");
            return;
        }

        Estudiante e = new Estudiante();

        Console.Write("Matrícula: "); e.Matricula = Console.ReadLine();
        Console.Write("Nombre: "); e.Nombre = Console.ReadLine();
        Console.Write("Apellido: "); e.Apellido = Console.ReadLine();
        Console.Write("Teléfono: "); e.Telefono = Console.ReadLine();
        Console.Write("Correo: "); e.Correo = Console.ReadLine();
        Console.Write("Carrera: "); e.Carrera = Console.ReadLine();
        Console.Write("Grado: "); e.Grado = Console.ReadLine();

        estudiantes[contador++] = e;
        Console.WriteLine("Estudiante agregado exitosamente.");
    }

    static void ModificarEstudiante()
    {
        Console.Write("Ingrese la matrícula del estudiante a modificar: ");
        string matricula = Console.ReadLine();

        for (int i = 0; i < contador; i++)
        {
            if (estudiantes[i].Matricula == matricula)
            {
                Console.Write("Nuevo Nombre: "); estudiantes[i].Nombre = Console.ReadLine();
                Console.Write("Nuevo Apellido: "); estudiantes[i].Apellido = Console.ReadLine();
                Console.Write("Nuevo Teléfono: "); estudiantes[i].Telefono = Console.ReadLine();
                Console.Write("Nuevo Correo: "); estudiantes[i].Correo = Console.ReadLine();
                Console.Write("Nueva Carrera: "); estudiantes[i].Carrera = Console.ReadLine();
                Console.Write("Nuevo Grado: "); estudiantes[i].Grado = Console.ReadLine();

                Console.WriteLine("Estudiante modificado correctamente.");
                return;
            }
        }

        Console.WriteLine("Estudiante no encontrado.");
    }

    static void EliminarEstudiante()
    {
        Console.Write("Ingrese la matrícula del estudiante a eliminar: ");
        string matricula = Console.ReadLine();

        for (int i = 0; i < contador; i++)
        {
            if (estudiantes[i].Matricula == matricula)
            {
                for (int j = i; j < contador - 1; j++)
                {
                    estudiantes[j] = estudiantes[j + 1];
                }
                estudiantes[--contador] = null;
                Console.WriteLine("Estudiante eliminado correctamente.");
                return;
            }
        }

        Console.WriteLine("Estudiante no encontrado.");
    }

    static void BuscarEstudiante()
    {
        Console.Write("Ingrese la matrícula del estudiante a buscar: ");
        string matricula = Console.ReadLine();

        for (int i = 0; i < contador; i++)
        {
            if (estudiantes[i].Matricula == matricula)
            {
                estudiantes[i].Mostrar();
                return;
            }
        }

        Console.WriteLine("Estudiante no encontrado.");
    }

    static void MostrarTodos()
    {
        Console.WriteLine("\nLista de estudiantes:");
        for (int i = 0; i < contador; i++)
        {
            estudiantes[i].Mostrar();
        }
    }
}