Console.Write("Ingrese un número entero: ");
int numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine($"El número {numero} es PAR");
}
else
{
    Console.WriteLine($"El número {numero} es IMPAR");
}