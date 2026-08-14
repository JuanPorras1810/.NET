//Contar vocales: Cuente cuántas vocales hay en un arreglo de caracteres.

Console.WriteLine("=== CONTADOR DE VOCALES ===");

//Arreglo
string[] caracteres = { "p", "o", "r", "r", "a", "s"};

//Ciclo contador
int contador = 0;
for (int i = 0; i < caracteres.Length; i++)
{
	if (caracteres[i] == "a" || caracteres[i] == "e" || caracteres[i] == "i" || caracteres[i] == "o" || caracteres[i] == "u")
	{
		contador ++;
	}
}
Console.WriteLine($"Hay en total: {contador}");