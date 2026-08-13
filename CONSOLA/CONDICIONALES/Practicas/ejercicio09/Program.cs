//Clasificacion de Triangulos: Determine si es equilátero, isósceles o escaleno.

Console.WriteLine("=== CLASIFICADOR DE TRIANGULOS ===");

//Captura de datos 
Console.Write("Ingrese el lado 1: ");
double lado1 = double.Parse(Console.ReadLine());

Console.Write("Ingrese el lado 2: ");
double lado2 = double.Parse(Console.ReadLine());

Console.Write("Ingrese el lado 3: ");
double lado3 = double.Parse(Console.ReadLine());

//Condicion
if (lado1 == lado2  &&  lado1 == lado3)
{
    Console.WriteLine("Triangulo equilatero");
}
else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
{
    Console.WriteLine("Triangulo isosceles");
}
else
{
    Console.WriteLine("Triangulo escaleno");
}