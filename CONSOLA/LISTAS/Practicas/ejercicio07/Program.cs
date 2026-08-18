//Ordenar lista de productos: Cree una lista de productos y ordénela por precio.

using ejercicio07;

Console.WriteLine("=== PRODUCTOS POR PRECIO ===");

//Lista
List<Producto> list = new List<Producto>();
list.Add(new Producto { Nombre = "Arroz", Precio = 3500 });
list.Add(new Producto { Nombre = "Leche", Precio = 6500 });
list.Add(new Producto { Nombre = "Cafe", Precio = 30000 });
list.Add(new Producto { Nombre = "Huevos", Precio = 18000 });

//Ordenar precio
list.Sort((a,b) => a.Precio.CompareTo(b.Precio));

//Salida
foreach (var item in list)
{
    Console.WriteLine($"{item.Nombre} - {item.Precio}");
}