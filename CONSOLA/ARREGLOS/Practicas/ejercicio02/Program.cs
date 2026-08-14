//Suma de elementos: Cree un arreglo de 5 números y calcule la suma total.

Console.WriteLine("=== SUMA DE 5 ELEMENTOS ===");

//Arreglo
int[] numero = new int[5];
numero[0] = 5;
numero[1] = 10;
numero[2] = 15;
numero[3] = 20;
numero[4] = 25;

//Ciclo para suma
int suma = 0;
for (int i = 0; i < numero.Length; i++)
{
    suma += numero[i];
}

//Salida
Console.WriteLine($"La suma de {numero[0]} + {numero[1]} + {numero[2]} + {numero[3]} + {numero[4]} = {suma}");