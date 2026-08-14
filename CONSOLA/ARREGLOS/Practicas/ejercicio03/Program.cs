//Encontrar el mayor: Encuentre el numero mayor en un arreglo de 10 elementos.

Console.WriteLine("=== ENCUENTRA EL NUMERO MAYOR ===");

//Arreglo
int[] numero = { 10, 3, 7, 8, 14, 18, 11, 99, 2, 9, 15 };

Console.Write("Numeros del arreglo: [ ");
for (int i = 0; i < numero.Length; i++)
{
	if (i == numero.Length - 1)
	{
        Console.Write(numero[i] + " ]");
    }
	else
	{
        Console.Write(numero[i] + ", ");
    }
}

//Ordena el arreglo
Array.Sort(numero);

//Toma el ultimo numero
int mayor = numero.Length - 1;

//Salida
Console.WriteLine($"\nEl numero mayor es: {numero[mayor]}");