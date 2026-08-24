//Metodo que recibe interface: Cree método que acepte lImprimible y funcione con Documento y Foto.

using ejercicio06;

Console.WriteLine("=== IMPRIMIR ===");

//Objetos que implementan la interfaz IImprimible
Foto foto = new Foto();
Documento documento = new Documento();
Impresora impresora = new Impresora();

//Bucle que solicita una opción e imprime una respuesta
while (true)
{
    Console.Write("Ingrese 1 si quiere foto, 2 si quiere documento o 3 para imprimir ambos: ");

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
        else if (eleccion == 3)
        {
            List<IImprimible> imprimir = new List<IImprimible>();
            imprimir.Add(foto);
            imprimir.Add(documento);

            impresora.ImprimirTodo(imprimir);
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