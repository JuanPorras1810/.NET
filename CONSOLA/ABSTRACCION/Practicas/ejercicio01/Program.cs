//Clase abstracta Animal: Animal con metodo abstracto HacerSonido(). Perro y Gato lo implementan.

using ejercicio01;

Console.WriteLine("=== SONIDO ANIMAL ===");

//Objetos para sonido del animal

Animal perro = new Perro();
Animal gato = new Gato();

//Bucle que toma la opcion y imprime un resultado
while (true)
{
	Console.Write("Ingrese 1 si quiere el sonido del perro o 2 si quiere el del gato");
	if (int.TryParse(Console.ReadLine(), out int animal ))
	{
		if (animal == 1)
		{
			perro.HacerSonido();
		}
		else if (animal == 2)
		{
			gato.HacerSonido();
		}
		else
		{
			Console.WriteLine("Opcion no valida...");
		}

	}
	else
	{
		Console.WriteLine("Error, solo se permite numeros");
	}
}