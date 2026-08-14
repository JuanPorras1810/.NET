class Estudiante
{
    public string Codigo { get; set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public double Nota { get; set; }

    public void MostrarInfo()
    {
        Console.WriteLine($"Código: {Codigo}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad} años");
        Console.WriteLine($"Nota: {Nota:F2}");
        Console.WriteLine((Nota >= 3.0 ? "Estado: ✅ APROBADO" : "Estado: ❌ REPROBADO"));
    }
}

class Programa
{
    static List<Estudiante> estudiantes = new List<Estudiante>();

    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║   SISTEMA DE GESTIÓN DE ESTUDIANTES   ║");
            Console.WriteLine("║           SENA - CSET BUCARAMANGA      ║");
            Console.WriteLine("╚════════════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine("1. Agregar Estudiante");
            Console.WriteLine("2. Listar Estudiantes");
            Console.WriteLine("3. Buscar Estudiante");
            Console.WriteLine("4. Actualizar Estudiante");
            Console.WriteLine("5. Eliminar Estudiante");
            Console.WriteLine("6. Salir");
            Console.WriteLine();
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1": AgregarEstudiante(); break;
                case "2": ListarEstudiantes(); break;
                case "3": BuscarEstudiante(); break;
                case "4": ActualizarEstudiante(); break;
                case "5": EliminarEstudiante(); break;
                case "6": continuar = false; Console.WriteLine("\n¡Gracias!"); break;
                default: Console.WriteLine("\n❌ Opción no válida"); Console.ReadKey(); break;
            }
        }
    }

    static void AgregarEstudiante()
    {
        Console.WriteLine("\n=== AGREGAR ESTUDIANTE ===");
        try
        {
            Console.Write("Código: ");
            string codigo = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(codigo))
            {
                Console.WriteLine("❌ El código no puede estar vacío");
                Console.ReadKey();
                return;
            }

            foreach (var est in estudiantes)
            {
                if (est.Codigo == codigo)
                {
                    Console.WriteLine("❌ Ya existe un estudiante con ese código");
                    Console.ReadKey();
                    return;
                }
            }

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad < 0 || edad > 100)
            {
                Console.WriteLine("❌ La edad debe estar entre 0 y 100");
                Console.ReadKey();
                return;
            }

            Console.Write("Nota: ");
            double nota = double.Parse(Console.ReadLine());

            if (nota < 0.0 || nota > 5.0)
            {
                Console.WriteLine("❌ La nota debe estar entre 0.0 y 5.0");
                Console.ReadKey();
                return;
            }

            estudiantes.Add(new Estudiante { Codigo = codigo, Nombre = nombre, Edad = edad, Nota = nota });
            Console.WriteLine("\n✅ Estudiante agregado exitosamente");
        }
        catch (FormatException)
        {
            Console.WriteLine("\n❌ Error: Ingrese valores numéricos válidos");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\n❌ Error: {ex.Message}");
        }
        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();
    }

    static void ListarEstudiantes()
    {
        Console.WriteLine("\n=== LISTA DE ESTUDIANTES ===");
        if (estudiantes.Count == 0)
        {
            Console.WriteLine("⚠️ No hay estudiantes registrados");
        }
        else
        {
            foreach (var est in estudiantes)
            {
                Console.WriteLine("─────────────────────────────────");
                est.MostrarInfo();
            }
            Console.WriteLine("─────────────────────────────────");
            Console.WriteLine($"Total: {estudiantes.Count} estudiante(s)");
        }
        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();
    }

    static void BuscarEstudiante()
    {
        Console.WriteLine("\n=== BUSCAR ESTUDIANTE ===");
        Console.Write("Ingrese el código: ");
        string codigo = Console.ReadLine();
        bool encontrado = false;

        foreach (var est in estudiantes)
        {
            if (est.Codigo == codigo)
            {
                Console.WriteLine("\n=== ESTUDIANTE ENCONTRADO ===");
                est.MostrarInfo();
                encontrado = true;
                break;
            }
        }

        if (!encontrado) Console.WriteLine("\n❌ Estudiante no encontrado");
        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();
    }

    static void ActualizarEstudiante()
    {
        Console.WriteLine("\n=== ACTUALIZAR ESTUDIANTE ===");
        Console.Write("Código: ");
        string codigo = Console.ReadLine();
        bool encontrado = false;

        foreach (var est in estudiantes)
        {
            if (est.Codigo == codigo)
            {
                Console.WriteLine("\n=== DATOS ACTUALES ===");
                est.MostrarInfo();

                Console.Write("\nNuevo Nombre (Enter para mantener): ");
                string nombre = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(nombre)) est.Nombre = nombre;

                Console.Write("Nueva Edad (Enter para mantener): ");
                string edad = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(edad)) est.Edad = int.Parse(edad);

                Console.Write("Nueva Nota (Enter para mantener): ");
                string nota = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(nota)) est.Nota = double.Parse(nota);

                Console.WriteLine("\n✅ Estudiante actualizado");
                encontrado = true;
                break;
            }
        }

        if (!encontrado) Console.WriteLine("\n❌ Estudiante no encontrado");
        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();
    }

    static void EliminarEstudiante()
    {
        Console.WriteLine("\n=== ELIMINAR ESTUDIANTE ===");
        Console.Write("Código: ");
        string codigo = Console.ReadLine();
        bool encontrado = false;

        foreach (var est in estudiantes)
        {
            if (est.Codigo == codigo)
            {
                Console.WriteLine("\n=== DATOS ===");
                est.MostrarInfo();
                Console.Write("\n¿Eliminar? (S/N): ");
                if (Console.ReadLine().ToUpper() == "S")
                {
                    estudiantes.Remove(est);
                    Console.WriteLine("\n✅ Eliminado");
                }
                else
                {
                    Console.WriteLine("\n⚠️ Cancelado");
                }
                encontrado = true;
                break;
            }
        }

        if (!encontrado) Console.WriteLine("\n❌ No encontrado");
        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();
    }
}