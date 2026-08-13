//Calcular edad futura: Pida el año de nacimiento y diga cuántos años tendrá en 2050.

Console.WriteLine("=== CALCULAR EDAD EN 2050 ===");

//Captura de datos
Console.Write("Ingrese su año de nacimiento: ");
int AñoNacimiento = int.Parse(Console.ReadLine());

//Proceso
int AñoLimite = 2050;
int EdadFutura = AñoLimite - AñoNacimiento;

//Salida
Console.WriteLine($"Tu edad en el 2050 sera de {EdadFutura} años");

