//Sistema de Envios: Interface IEnvio con método CalcularCosto(). EnvioNacional e Enviolnternacional lo implementan.

using ejercicio04;

Console.WriteLine("=== SISTEME DE ENVIOS ===");

//Objetos para las operaciones
Enviolnternacional internacional = new Enviolnternacional();
EnvioNacional nacional = new EnvioNacional();

//Bucle que toma la opcion y imprime un resultado
while (true)
{
    Console.Write("Ingrese 1 para envio nacional o 2 para envio internacional: ");
    if (int.TryParse(Console.ReadLine(), out int opcion))
    {
        if (opcion == 1)
        {
            while (true)
            {
                Console.Write("Ingrese el peso del envio nacional en (kg): ");
                if (int.TryParse(Console.ReadLine(), out int peso))
                {
                    if (peso > 0)
                    {
                        nacional.Peso = peso;
                    }
                    else
                    {
                        Console.WriteLine("El numero debe ser positivo mayor que cero");
                    }
                }
                Console.WriteLine($"El envio nacional tiene un costo de: {nacional.CalcularCosto()}");
                break;
            }
        }
        else if (opcion == 2)
        {
            while (true)
            {
                Console.Write("Ingrese el peso del envio internacional en (kg): ");
                if (int.TryParse(Console.ReadLine(), out int peso))
                {
                    if (peso > 0)
                    {
                        internacional.Peso = peso;
                    }
                    else
                    {
                        Console.WriteLine("El numero debe ser positivo mayor que cero");
                    }
                }
                Console.WriteLine($"El envio internacional tiene un costo de: {internacional.CalcularCosto()}");
                break;
            }
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