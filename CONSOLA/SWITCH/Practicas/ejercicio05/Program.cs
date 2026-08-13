//Semáforo: Muestre la acción según el color del semáforo (rojo, amarillo, verde).

Console.WriteLine("=== SEMAFORO ===");

//Captura de datos
Console.Write("Ingrese el color del semaforo: ");
string color = Console.ReadLine().ToLower();

//Switch
switch (color)
{
	case "rojo":
		Console.WriteLine("Detengase");
		break;

    case "amarillo":
        Console.WriteLine("Precaucion");
        break;

    case "verde":
        Console.WriteLine("Avance");
        break;

    default:
        Console.WriteLine("Error, color no valido");
        break;
}