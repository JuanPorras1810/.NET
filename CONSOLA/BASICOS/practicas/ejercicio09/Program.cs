//Area de un círculo: Pida el radio y calcule el área (pi x r2). Use pi = 3.1416.

Console.WriteLine("=== Area del círculo ===");

//Captura de datos
Console.Write("Ingrese el radio del circulo: ");
double radio = double.Parse(Console.ReadLine());

//Proceso
double pi = 3.1416;
double area = (pi * (radio * radio));

//Salida
Console.WriteLine($"Area: {area}");
