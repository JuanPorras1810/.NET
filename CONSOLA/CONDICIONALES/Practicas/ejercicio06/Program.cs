//Temperatura de alerta: Muestre "Alerta de calor" si la temperatura supera los 35°C.

Console.WriteLine("=== MEDIDOR DE CALOR ===");

//Captura de datos
Console.Write("Ingrese la temperatura en (°C): ");
double temperatura = double.Parse(Console.ReadLine());

//Condicional
if (temperatura > 35)
{
    Console.WriteLine("Alerta de calor");
}
