//Validar edad con TryParse: Use TryParse para validar edad. Debe estar entre 0 y 120.

Console.WriteLine("=== VALIDADOR DE EDAD ===");

//Captura de datos
Console.Write("Ingrese su edad: ");

//TryParse
if (int.TryParse(Console.ReadLine(), out int edad))
{
	if (edad >= 0 && edad <= 120)
	{
		Console.WriteLine($"Edad valida: {edad} años");
	}
	else
	{
        Console.WriteLine($"Edad invalida: {edad} años esta fuera del rango de (0 - 120)");
    }
}