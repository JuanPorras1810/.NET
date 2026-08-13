//Nombre del mes: Muestre el nombre del mes según el número ingresado (1-12).

Console.WriteLine("=== IDENTIFICADOR DIA DEL MES POR NUMERO ===");

//Captura de datos
Console.Write("Ingrese un numero del (1-12): ");
int numero = int.Parse(Console.ReadLine());

//Switch
switch (numero)
{
	case 1:
		Console.WriteLine("Enero");
		break;

    case 2:
        Console.WriteLine("Febrero");
        break;

    case 3:
        Console.WriteLine("Marzo");
        break;

    case 4:
        Console.WriteLine("Abril");
        break;

    case 5:
        Console.WriteLine("Mayo");
        break;

    case 6:
        Console.WriteLine("Junio");
        break;

    case 7:
        Console.WriteLine("Julio");
        break;

    case 8:
        Console.WriteLine("Agosto");
        break;

    case 9:
        Console.WriteLine("Septiembre");
        break;

    case 10:
        Console.WriteLine("Octubre");
        break;

    case 11:
        Console.WriteLine("Noviembre");
        break;

    case 12:
        Console.WriteLine("Diciembre");
        break;


    default:
        Console.WriteLine("Error numero no valido");
        break;
}