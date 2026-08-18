//Eliminar por valor: Cree una lista y elimine un elemento específico si existe.

Console.WriteLine("=== ELIMINA ELEMENTO DE LISTA ===");

//Lista
List<string> frutas = new List<string> { "Manzana", "Pera", "Uva", "Banano", "Fresa"};

//Salida
Console.Write("Lista de frutas: ");
foreach (var item in frutas)
{
    Console.Write($"{item} ");
}
Console.WriteLine();

if (frutas.Contains("Fresa"))
{
    frutas.Remove("Fresa");
    Console.WriteLine("Eliminando Fresa...");

    Console.Write("Lista final: ");
    foreach (var item in frutas)
    {
        Console.Write($"{item} ");
    }
}
