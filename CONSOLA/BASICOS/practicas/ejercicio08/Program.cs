//Calcular promedio de 3 notas: Pida 3 notas y calcule el promedio.

Console.WriteLine("=== PROMEDIO DE 3 NOTAS ===");

//Captura de datos
Console.Write("Ingrese la nota 1: ");
double nota1 = double.Parse(Console.ReadLine());

Console.Write("Ingrese la nota 2: ");
double nota2 = double.Parse(Console.ReadLine());

Console.Write("Ingrese la nota 3: ");
double nota3 = double.Parse(Console.ReadLine());

//Proceso
double promedio = ((nota1 + nota2 + nota3) / 3) ;

//Salida
Console.WriteLine($"El promedio es de {promedio} ");