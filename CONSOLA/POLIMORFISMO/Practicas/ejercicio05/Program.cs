//Interface IImprimible: Interface con método Imprimir(). Documento y Foto lo implementan.

using ejercicio05;

Console.WriteLine("=== IMPRIMIR ===");

//Objetos que implementan la interfaz IImprimible
Foto foto = new Foto();
Documento documento = new Documento();

//Bucle que solicita una opción e imprime una respuesta
while (true)
{
    Console.Write("Ingrese 1 si quiere foto o 2 si quiere documento: ");
	if (int.TryParse(Console.ReadLine(), out int eleccion))
	{
        if (eleccion == 1)
        {
            foto.Imprimir();
        }
        else if (eleccion == 2)
        {
            documento.Imprimir();
        }
        else
        {
            Console.WriteLine("Eleccion no valida....");
        }
    }
    else
    {
        Console.WriteLine("Error, solo se permite numeros");
    }

}