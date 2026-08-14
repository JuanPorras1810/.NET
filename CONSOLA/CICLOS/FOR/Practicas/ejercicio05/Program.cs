//Números pares en rango: Muestre todos los numeros pares entre 1 y 50.

Console.WriteLine("=== NUMEROS PARES 1 - 50 ===");

//Ciclo
for (int i = 1; i <= 50; i++)
{
	if (i % 2 == 0)
	{
		if (i == 50)
		{
			Console.Write(i);
		}
		else 
		{ 
			Console.Write($"{i}, ");
		}
	}
}