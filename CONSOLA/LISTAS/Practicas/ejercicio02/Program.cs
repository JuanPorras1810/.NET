//Lista de compras: Cree una lista de 5 productos y muéstrelos todos.

using ejercicio02;

Console.WriteLine("=== LISTA DE COMPRAS ===");

//Lista
List<Compras> list = new List<Compras>();
list.Add(new Compras { Nombre = "Tomate", Cantidad = 4, Unidad = "lb" });
list.Add(new Compras { Nombre = "Cebolla", Cantidad = 3, Unidad = "lb" });
list.Add(new Compras { Nombre = "Carne de res", Cantidad = 6, Unidad = "lb" });
list.Add(new Compras { Nombre = "Sal", Cantidad = 1, Unidad = "lb" });
list.Add(new Compras { Nombre = "Aguacate", Cantidad = 2, Unidad = "unidades" });


//Salida
int cantidad = 1;
foreach (var item in list)
{
    Console.WriteLine($"Producto {cantidad}: {item.Nombre} - {item.Cantidad} {item.Unidad}");
    cantidad++;
}