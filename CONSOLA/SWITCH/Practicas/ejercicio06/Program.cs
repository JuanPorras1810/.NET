//Tamaño de pizza: Según el código (P, M, G), muestre el tamaño y precio de la pizza.

Console.WriteLine("=== MENU DE PIZZAS POR CODIGO ===");

//Captura de datos
Console.Write("Ingrese el codigo (P, M, G): ");
char codigo =  char.Parse(Console.ReadLine().ToUpper());

//Switch
switch (codigo)
{
	case 'P':
		Console.WriteLine("Tamaño: Pequeña -  Precio: $15000");
		break;

    case 'M':
        Console.WriteLine("Tamaño: Mediana -  Precio: $25000");
        break;

    case 'G':
        Console.WriteLine("Tamaño: Grande -  Precio: $35000");
        break;

    default:
        Console.WriteLine("Error, codigo no valido");
        break;
}
