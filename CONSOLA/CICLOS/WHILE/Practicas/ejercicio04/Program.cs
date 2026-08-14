//Suma hasta cero: Sume números ingresados por el usuario hasta que ingrese 0.

Console.WriteLine("=== SUMA DE NUMEROS ===");

//Captura de datos
Console.Write("Ingrese un numero y 0 para terminar: ");
int numero = int.Parse(Console.ReadLine());

int suma = 0; 

//Ciclo
while (numero != 0)
{
    suma += numero;
    Console.Write("Ingrese un numero y 0 para terminar: ");
    numero = int.Parse(Console.ReadLine());
}

//Salida
Console.WriteLine($"Suma: {suma}");