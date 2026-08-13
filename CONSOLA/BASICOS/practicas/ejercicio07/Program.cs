//Conversor de dolares a pesos: Pida una cantidad en dólares y conviértala a pesos (TRM: $4,000).

Console.WriteLine("=== CONVERSOR DE DOLARES A PESOS ===");

//Captura de datos
Console.Write("Ingrese la cantidad de dolares: ");
double dolar = double.Parse(Console.ReadLine());

//Proceso
double TRM = 4000;
double conversion = dolar * TRM;

//Salida
Console.WriteLine($"Los {dolar} dolares equivalen a {conversion} pesos colombianos");