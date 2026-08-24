//Sistema de Pagos: Clase abstracta Pago con métodos abstractos. Efectivo, Tarjeta y Transferencia como clases hijas.

using ejercicio03;

Console.WriteLine("=== GENERAR PAGO ===");

//Objetos
Pago efectivo = new Efectivo();
Pago tarjeta = new Tarjeta();
Pago transferencia = new Transferencia();

//Bucle que toma la opcion y imprime un resultado
while (true)
{
    Console.Write("Ingrese 1 para pago en efectivo 2 para pago con tarjeta o 3 para pago por transferencia: ");
    if (int.TryParse(Console.ReadLine(), out int opcion))
    {
        if (opcion == 1)
        {
            efectivo.GenerarPago();
            Console.ReadLine();
        }
        else if (opcion == 2)
        {
            tarjeta.GenerarPago();
            Console.ReadLine();
        }
        else if (opcion == 3)
        {
            transferencia.GenerarPago();
            Console.ReadLine();
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