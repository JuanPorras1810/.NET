using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SistemaEmpleados sistema = new SistemaEmpleados();
            bool salir = false;

            //Agregar empleados de ejemplo para pruebas
            InicializarDatosDeEjemplo(sistema);

            while (!salir)
            {
                MostrarMenu();
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarEmpleado(sistema);
                        break;

                    case "2":
                        sistema.MostrarTodosLosEmpleados();
                        EsperarTecla();
                        break;

                    case "3":
                        BuscarEmpleadoPorId(sistema);
                        break;

                    case "4":
                        BuscarEmpleadosPorCargo(sistema);
                        break;

                    case "5":
                        ActualizarSalario(sistema);
                        break;

                    case "6":
                        EliminarEmpleado(sistema);
                        break;

                    case "7":
                        MostrarNominaTotal(sistema);
                        break;

                    case "8":
                        sistema.MostrarEstadisticas();
                        EsperarTecla();
                        break;

                    case "9":
                        salir = true;
                        Console.WriteLine("\n¡Gracias por usar el Sistema de Gestión de Empleados! Hasta pronto.\n");
                        break;

                    default:
                        Console.WriteLine("\n Opción inválida. Por favor selecciona una opción del 1 al 9.\n");
                        EsperarTecla();
                        break;
                }
            }
        }

        //Métodos para la interfaz de consola
        static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("\n" + "=".PadRight(60, '=') + "\n");
            Console.WriteLine("  SISTEMA DE GESTIÓN DE EMPLEADOS \n");
            Console.WriteLine("=".PadRight(60, '=') + "\n");
            Console.WriteLine(" 1.Agregar nuevo empleado");
            Console.WriteLine(" 2.Mostrar todos los empleados");
            Console.WriteLine(" 3.Buscar empleado por ID");
            Console.WriteLine(" 4.Buscar empleados por cargo");
            Console.WriteLine(" 5.Actualizar salario de empleado");
            Console.WriteLine(" 6.Eliminar empleado");
            Console.WriteLine(" 7.Calcular nómina total");
            Console.WriteLine(" 8.Mostrar estadísticas");
            Console.WriteLine(" 9.Salir\n");
            Console.WriteLine("=".PadRight(60, '=') + "\n");
            Console.Write("Selecciona una opción (1-9): ");
        }

        static void AgregarEmpleado(SistemaEmpleados sistema)
        {
            Console.Clear();
            Console.WriteLine("\n=== AGREGAR NUEVO EMPLEADO ===\n");

            try
            {
                Console.Write("Nombre completo: ");
                string nombre = Console.ReadLine();

                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());

                Console.Write("Cargo: ");
                string cargo = Console.ReadLine();

                Console.Write("Salario mensual ($): ");
                decimal salario = decimal.Parse(Console.ReadLine());

                sistema.AgregarEmpleado(nombre, edad, cargo, salario);
            }
            catch (FormatException)
            {
                Console.WriteLine("\n Error: Formato de número inválido. Usa números sin caracteres especiales.\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n Error: {ex.Message}\n");
            }
            EsperarTecla();
        }

        static void BuscarEmpleadoPorId(SistemaEmpleados sistema)
        {
            Console.Clear();
            Console.WriteLine("\n=== BUSCAR EMPLEADO POR ID ===\n");

            try
            {
                Console.Write("Ingrese el ID del empleado: ");
                int id = int.Parse(Console.ReadLine());

                Empleado emp = sistema.BuscarPorId(id);

                if (emp != null)
                {
                    emp.MostrarInformacion();
                }
                else
                {
                    Console.WriteLine($"\nNo se encontró ningún empleado con el ID {id}.\n");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nError: El ID debe ser un número entero válido.\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError: {ex.Message}\n");
            }

            EsperarTecla();
        }


        static void BuscarEmpleadosPorCargo(SistemaEmpleados sistema)
        {
            Console.Clear();
            Console.WriteLine("\n=== BUSCAR EMPLEADOS POR CARGO ===\n");

            try
            {
                Console.Write("Ingrese el cargo a buscar: ");
                string cargo = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(cargo))
                {
                    throw new Exception("El campo de búsqueda no puede estar vacío.");
                }

                List<Empleado> coincidencia = sistema.BuscarPorCargo(cargo);

                if (coincidencia.Count > 0)
                {
                    Console.WriteLine($"\nSe encontraron {coincidencia.Count} empleado(s) con el cargo '{cargo}':");
                    foreach (var emp in coincidencia)
                    {
                        emp.MostrarInformacion();
                    }
                }
                else
                {
                    Console.WriteLine($"\nNo se encontraron empleados registrados con el cargo '{cargo}'.\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError: {ex.Message}\n");
            }

            EsperarTecla();
        }


        static void ActualizarSalario(SistemaEmpleados sistema)
        {
            Console.Clear();
            Console.WriteLine("\n=== ACTUALIZAR SALARIO DE EMPLEADO ===\n");

            try
            {
                Console.Write("Ingrese el ID del empleado: ");
                int id = int.Parse(Console.ReadLine());

                Empleado emp = sistema.BuscarPorId(id);

                if (emp != null)
                {
                    Console.WriteLine($"Empleado seleccionado: {emp.Nombre} | Salario actual: ${emp.Salario:N2}\n");

                    Console.Write("Ingrese el nuevo salario ($): ");
                    decimal nuevoSalario = decimal.Parse(Console.ReadLine());

                    //Llama a SistemaEmpleados, que aplicará las validaciones de encapsulamiento
                    sistema.ActualizarSalario(id, nuevoSalario);
                }
                else
                {
                    Console.WriteLine($"\nNo se encontró ningún empleado con el ID {id}.\n");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nError: Formato de número inválido. Asegúrate de ingresar solo números.\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError: {ex.Message}\n");
            }

            EsperarTecla();
        }

        static void EliminarEmpleado(SistemaEmpleados sistema)
        {
            Console.Clear();
            Console.WriteLine("\n=== ELIMINAR EMPLEADO ===\n");

            try
            {
                Console.Write("Ingrese el ID del empleado a eliminar: ");
                int id = int.Parse(Console.ReadLine());

                Empleado emp = sistema.BuscarPorId(id);

                if (emp != null)
                {
                    Console.Write($"¿Está seguro de eliminar a {emp.Nombre}? (S/N): ");
                    string confirmacion = Console.ReadLine()?.Trim().ToUpper();

                    if (confirmacion == "S")
                    {
                        sistema.EliminarEmpleado(id);
                    }
                    else
                    {
                        Console.WriteLine("\nOperación cancelada por el usuario.\n");
                    }
                }
                else
                {
                    Console.WriteLine($"\nNo se encontró ningún empleado con el ID {id}.\n");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nError: El ID debe ser un número entero válido.\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError: {ex.Message}\n");
            }

            EsperarTecla();
        }

        static void MostrarNominaTotal(SistemaEmpleados sistema)
        {
            Console.Clear();
            Console.WriteLine("\n=== CÁLCULO DE NÓMINA TOTAL ===\n");

            try
            {
                decimal total = sistema.CalcularNominaTotal();
                Console.WriteLine($"El costo total de la nómina mensual es: ${total:N2}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError al calcular la nómina: {ex.Message}\n");
            }

            EsperarTecla();
        }


        // ... (otros métodos auxiliares: BuscarEmpleadoPorId, BuscarEmpleadosPorCargo, etc.)
        // ... (método InicializarDatosDeEjemplo para agregar empleados de prueba)
        // ... (método EsperarTecla para pausar la ejecución)

        // Método para inicializar datos de ejemplo
        static void InicializarDatosDeEjemplo(SistemaEmpleados sistema)
        {
            // Agregar empleados de ejemplo para facilitar las pruebas
            sistema.AgregarEmpleado("Ana García", 32, "Gerente de Proyectos", 8500.00m);
            sistema.AgregarEmpleado("Carlos Rodríguez", 28, "Desarrollador Senior", 7200.00m);
            sistema.AgregarEmpleado("María López", 25, "Diseñadora UX/UI", 6500.00m);
            sistema.AgregarEmpleado("Juan Pérez", 35, "Analista de Datos", 6800.00m);
            sistema.AgregarEmpleado("Laura Martínez", 30, "Desarrollador Frontend", 6200.00m);
        }

        static void EsperarTecla()
        {
            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
        }
    
    }
}
