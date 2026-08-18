//Promedio de notas: Calcule el promedio de 5 notas almacenadas en un arreglo.

Console.WriteLine("=== PROMEDIO DE NOTAS ===");

//Arreglo
double[] notas = { 4, 2, 10, 6, 8 };

//Ciclo que suma notas
double suma = 0;
Console.Write($"Notas: [ ");
for (int i = 0; i < notas.Length; i++)
{
    if (i < notas.Length - 1)
    {
        Console.Write(notas[i] + ", ");
    }
    else
    {
        Console.WriteLine(notas[i] + " ]");
    }
    suma += notas[i];
}

//Calculo promedio
double promedio = suma / notas.Length;
Console.WriteLine($"Promedio: {promedio}");