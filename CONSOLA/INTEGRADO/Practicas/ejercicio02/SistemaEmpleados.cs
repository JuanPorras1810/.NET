using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio02
{
    internal class SistemaEmpleados
    {

        private List<Empleado> empleados;
        private int siguienteId;


        public SistemaEmpleados()
        {
            empleados = new List<Empleado>();
            siguienteId = 1;
        }

        //OPERACIONES CRUD

        //CREATE: Agregar nuevo empleado
        public bool AgregarEmpleado(string nombre, int edad, string cargo, decimal salario)
        {
            try
            {
                Empleado nuevoEmpleado = new Empleado(siguienteId, nombre, edad, cargo, salario);
                empleados.Add(nuevoEmpleado);
                siguienteId++;

                Console.WriteLine($"\nEmpleado agregado exitosamente con ID: {nuevoEmpleado.Id}\n");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError al agregar empleado: {ex.Message}\n");
                return false;
            }
        }

        //Mostrar todos los empleados
        public void MostrarTodosLosEmpleados()
        {
            Console.WriteLine("\n=== LISTA DE EMPLEADOS ===\n");

            if (empleados.Count == 0)
            {
                Console.WriteLine("No hay empleados registrados en el sistema.\n");
                return;
            }

            foreach (Empleado empleado in empleados)
            {
                empleado.MostrarInformacion();
            }
        }

        //Buscar empleado por ID
        public Empleado BuscarPorId(int id)
        {
            return empleados.Find(e => e.Id == id);
        }

        //Buscar empleados por cargo
        public List<Empleado> BuscarPorCargo(string cargo)
        {
            return empleados.Where(e => e.Cargo.Equals(cargo, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        //Actualizar salario de un empleado
        public bool ActualizarSalario(int id, decimal nuevoSalario)
        {
            Empleado empleado = BuscarPorId(id);

            if (empleado == null)
            {
                Console.WriteLine($"\n No se encontró empleado con ID {id}\n");
                return false;
            }

            try
            {
                empleado.Salario = nuevoSalario;
                Console.WriteLine($"\nSalario actualizado exitosamente para {empleado.Nombre}\n");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError al actualizar salario: {ex.Message}\n");
                return false;
            }
        }

        //DELETE: Eliminar empleado por ID
        public bool EliminarEmpleado(int id)
        {
            Empleado empleado = BuscarPorId(id);

            if (empleado == null)
            {
                Console.WriteLine($"\nNo se encontró empleado con ID {id}\n");
                return false;
            }

            empleados.Remove(empleado);
            Console.WriteLine($"\nEmpleado {empleado.Nombre} eliminado exitosamente\n");
            return true;
        }


        //Calcular nómina total de la empresa
        public decimal CalcularNominaTotal()
        {
            return empleados.Sum(e => e.Salario);
        }

        //Generar estadísticas básicas
        public void MostrarEstadisticas()
        {
            Console.WriteLine("\n=== ESTADÍSTICAS DEL SISTEMA ===\n");
            Console.WriteLine($"Total de empleados: {empleados.Count}");

            if (empleados.Count > 0)
            {
                decimal nominaTotal = CalcularNominaTotal();
                decimal salarioPromedio = nominaTotal / empleados.Count;
                Empleado mejorPagado = empleados.OrderByDescending(e => e.Salario).First();

                Console.WriteLine($"Nómina total mensual: ${nominaTotal:N2}");
                Console.WriteLine($"Salario promedio: ${salarioPromedio:N2}");
                Console.WriteLine($"Empleado mejor pagado: {mejorPagado.Nombre} (${mejorPagado.Salario:N2})");
                Console.WriteLine($"Cargos únicos: {empleados.Select(e => e.Cargo).Distinct().Count()}");
            }
            else
            {
                Console.WriteLine("No hay datos suficientes para generar estadísticas.\n");
            }
        }
    }
}
