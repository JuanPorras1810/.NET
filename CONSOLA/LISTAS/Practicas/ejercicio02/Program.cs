//Lista de compras: Cree una lista de 5 productos y muéstrelos todos.

Console.WriteLine("=== LISTA DE COMPRAS ===");

//Lista
List<string> list = new List<string>();
list.Add("Tomate - 4 lb");
list.Add("Cebolla - 3 lb");
list.Add("Carne de res - 6 lb");
list.Add("Sal - 1 lb");
list.Add("Aguacate - 2");

//Salida
int cantidad = 1;
foreach (var item in list)
{
    Console.WriteLine($"Producto {cantidad}: {item}");
    cantidad++;
}