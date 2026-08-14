//Sistema de reintentos con finally: Permita 3 intentos para ingresar un numero. Use finally para mensaje final.

Console.WriteLine("=== SISTEMA DE REINTENTOS ==="); 

//Numero random
Random num = new Random();
int random = num.Next(1,11);

//Try-catch
try
{
    int intentos = 1;
	while (intentos <= 3)
	{
        Console.WriteLine($"Intento {intentos} de 3");
        Console.Write("Ingrese un numero del 1 - 10: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero == random)
        {
            Console.WriteLine("¡FELICIDADES! Adivinaste el numero");
            break;
        }
		else
		{
            Console.WriteLine("Numero incorrecto");
        }
        intentos++;
    }

}
catch (FormatException)
{
    Console.WriteLine("Error: Solo se permiten numeros.");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
finally
{
    Console.WriteLine("Juego finalizado...");
}