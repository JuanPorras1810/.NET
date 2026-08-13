//Número divisible por 5: Pida un número y muestre un mensaje si es divisible entre 5.

Console.WriteLine("=== NUMEROS DIVISIBLES POR 5 ===");

//Captura de datos
Console.Write("Ingrese un numero: ");
int numero = int.Parse(Console.ReadLine());

//Condicional
if (numero % 5 == 0)
{
    Console.WriteLine($"El numero {numero} es divisible por 5");
}