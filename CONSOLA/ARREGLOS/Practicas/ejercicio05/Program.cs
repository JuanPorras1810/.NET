//Invertir arreglo: Cree un nuevo arreglo con los elementos del original en orden inverso.

Console.WriteLine("=== INVERTIDOR DE ARREGO===");

//Arreglo
string[] nombres = { "Juan", "Carlos", "Camilo", "Stiven", "Brayan"};

//Salida
Console.Write($"Arreglo original: [ ");
for (int i = 0; i < nombres.Length; i++)
{
	if (i < nombres.Length - 1)
	{
		Console.Write(nombres[i] + ", ");
	}
	else
	{
		Console.WriteLine(nombres[i] + " ]" );
	}
}

Array.Reverse( nombres );

Console.Write($"Arreglo invertido: [ ");
for (int i = 0; i < nombres.Length; i++)
{
    if (i < nombres.Length - 1)
    {
        Console.Write(nombres[i] + ", ");
    }
    else
    {
        Console.WriteLine(nombres[i] + " ]");
    }
}