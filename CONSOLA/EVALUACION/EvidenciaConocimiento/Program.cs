//Calculo de salario con deducciones
try
{
    bool validador = true;
    while (validador == true)
    {
        //Captura de datos
        Console.Write("Nombre del empleado: ");
        string nombre = Console.ReadLine();

        Console.Write("Cantidad de horas trabajadas: ");
        int horas = int.Parse(Console.ReadLine());

        if (horas <= 0)
        {
                Console.WriteLine("Hora no valida...");
            break;
        }

        Console.Write("Valor de la hora: ");
        int ValorHoras = int.Parse(Console.ReadLine());
        if (ValorHoras <= 0)
        {
            Console.WriteLine("Valor de horas no valido...");
            break;
        }

        //Procesos
        double SalarioBruto = horas * ValorHoras;
        double salud = SalarioBruto * 0.08;
        double pension = SalarioBruto * 0.04;
        double salarioNeto = SalarioBruto - salud - pension;

        //Salida
        Console.WriteLine("----- RESUMEN DE PAGO -----");
        Console.WriteLine($"Empleado: {nombre}");
        Console.WriteLine($"Salario bruto: {SalarioBruto:f2}");
        Console.WriteLine($"Descuento de salud: {salud:f2}");
        Console.WriteLine($"Descuento de pension: {pension:f2}");
        Console.WriteLine($"Salario neto: {salarioNeto:f2}");

        //Pregunta si desea continuar
        Console.Write("Desea continuar con otro empleado escriba(Y/N)");
        char pregunta = char.Parse(Console.ReadLine());
        if (pregunta == 'y')
        {
            Console.WriteLine("Siguiente empleado...");
        }
        else if (pregunta == 'n')
        {
            validador = false;
        }
        else
        {
            Console.WriteLine("Error opcion no valida");
            return;
        }

    }
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
