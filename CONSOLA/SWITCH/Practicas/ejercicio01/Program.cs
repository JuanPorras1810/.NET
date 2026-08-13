Console.Write("Ingresa el dia de la semana: ");
int dia = Convert.ToInt32(Console.ReadLine());

switch (dia)
{
    case 1:
        Console.WriteLine("Domingo");
        break;

    case 2:
        Console.WriteLine("Lunes");
        break;

    case 3:
        Console.WriteLine("Martes");
        break;

    case 4:
        Console.WriteLine("Miercoles");
        break;

    case 5:
        Console.WriteLine("Jueves");
        break;

    case 6:
        Console.WriteLine("Viernes");
        break;

    case 7:
        Console.WriteLine("Sabado");
        break;

    default:
        Console.WriteLine("Pailas papi...");
        break;
}