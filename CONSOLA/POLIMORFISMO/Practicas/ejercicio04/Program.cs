using ejercicio04;

//Clase abstracta Forma: Forma con metodo abstracto CalcularArea(). Circulo y Cuadrado lo implementan.

Console.WriteLine("=== AREA FIGURAS ===");

//Objetos para crear figuras con sus medidas
Area cuadrado = new Cuadrado(4);
Area circulo = new Circulo(8);

//salida
Console.WriteLine($"El area del cuadrado es: {cuadrado.CalcularArea()}");
Console.WriteLine($"El area del circulo es: {circulo.CalcularArea()}");
