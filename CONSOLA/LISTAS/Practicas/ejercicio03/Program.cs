//Suma de números: Cree una lista de 10 números y calcule la suma total.

Console.WriteLine("=== SUMA DE NUMEROS ===");

//Lista
List<int> numeros = new List<int> { 1, 4, 52, 34, 12, 23, 45, 65, 100, 18 };

//Salida
int total = 0;
foreach (var item in numeros)
{ 
    total += item;
}
Console.WriteLine($"La suma de: {numeros[0]} + {numeros[1]} + {numeros[2]} + {numeros[1]} + {numeros[3]} + {numeros[4]} + " +
    $"{numeros[5]} + {numeros[6]} + {numeros[7]} + {numeros[8]} + {numeros[9]} = {total}");