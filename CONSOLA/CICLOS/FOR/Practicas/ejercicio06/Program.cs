//Triangulo de asteriscos: Dibuje un triángulo rectángulo de '*' según la altura ingresada.

Console.WriteLine("=== GENERADOR DE TRIANGULOS ===");

//Captura de datos
Console.Write("Ingrese la altura: ");
int altura = int.Parse(Console.ReadLine());

//Ciclo
for (int i = 1; i <= altura; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}