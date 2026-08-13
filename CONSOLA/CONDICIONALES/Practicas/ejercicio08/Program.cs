//Año Bisiesto: Determine si un año es bisiesto.

Console.WriteLine("=== DECTECTOR DE AÑOS BISIESTOS ===");

//Captura de datos
Console.Write("Ingrese el año: ");
int año = int.Parse(Console.ReadLine());

//Condicional
if ((año % 4 == 0 &&  100 != 0) || (año % 400 == 0) )
{
    Console.WriteLine($"El año {año} es bisiesto");
}
else
{
    Console.WriteLine($"El año {año} no es bisiesto");
}