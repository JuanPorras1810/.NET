//Adivina el numero con pistas: El programa elige un numero del 1-100. El usuario adivina con pistas 'mayor/menor'.

Console.WriteLine("=== ADIVINA EL NUMERO===");

//Numero aleatorio
Random numero = new Random();
int random = numero.Next(1,101);

//Ciclo
while (true)
{
	Console.Write("Ingresa un numero del 1 - 100: ");
	int NumIngre = int.Parse(Console.ReadLine());

	if (random > NumIngre)
	{
        Console.WriteLine("Pista: El numero es mayor");
    }
    else if (random < NumIngre)
    {
        Console.WriteLine("Pista: El numero es menor");
    }
	else
	{
        Console.WriteLine("¡FELICIDADES! has adivinado el numero");
        break;
    }
}