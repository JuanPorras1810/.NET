//Dependency Injection básica: Clase que recibe interface por constructor en lugar de clase concreta.

using ejercicio05;

Console.WriteLine("=== PROMEDIO ===");

//Objeto para generar promedio nota
Notas pro = new Notas(5,10,6);

//Salida
Console.WriteLine($"El promedio es: {pro.Promedio()}");
