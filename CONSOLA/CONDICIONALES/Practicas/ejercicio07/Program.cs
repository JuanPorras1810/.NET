//Positivo o Negativo: Determine si un número es positivo o negativo.

Console.WriteLine("=== DETERMINAR NUMERO POSITIVO O NEGATIVO===");

//Captura de datos
Console.Write("Ingrese un numero: ");
int numero = int.Parse(Console.ReadLine());

//Condicional
if (numero >= 0)
{
    Console.WriteLine("Numero positivo");
}
else
{
    Console.WriteLine("Numero negativo");
}