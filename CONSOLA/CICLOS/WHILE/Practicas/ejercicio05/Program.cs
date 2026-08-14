//Cajero con validacion de PIN: Use while(true) para validar un PIN de 4 dígitos. Máximo 3 intentos.

Console.WriteLine("=== CAJERO CON VALIDACION DE PIN ===");

//Datos por defecto
string PinEstablecido = "1234";
int intentos = 0; 

//Ciclo
while (true)
{
    Console.Write("Ingrese codigo de cagero (4 digitos): ");
    string pin = Console.ReadLine();

    if (pin == PinEstablecido)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Ingreso exitoso...");
        Console.ForegroundColor = ConsoleColor.White;
        break;
    }
    else
    {
        intentos++;
        if (intentos >= 3)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Cuenta bloqueado por maximo de intentos");
            Console.ForegroundColor = ConsoleColor.White;
            break;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"intento fallido te quedan {3-intentos} / 3");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

}