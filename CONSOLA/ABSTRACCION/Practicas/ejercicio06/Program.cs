//Interface Segregation: Cree 2 interfaces pequeñas en lugar de 1 grande con muchos métodos.

using ejercicio06;

Console.WriteLine("=== MOSTRAR INFORMACION PERRO ===");

//Objeto
Animal perro = new Animal();

//Salida
Console.Write($"Accion: ");
perro.MostrarAccion();
Console.Write("Raza: ");
perro.MostrarRaza();