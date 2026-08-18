//Filtrar numeros pares: Cree una lista de 20 números y muestre solo los pares.

Console.WriteLine("=== FILTRO DE NUMEROS PARES ===");

//Lista
List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};

//Salida

foreach (var item in numeros)
{
    if (item % 2 == 0)
	{
		Console.Write($"{item}, ");
	}
}
