//Potencia de un numero: Calcule X elevado a la Y usando while (sin usar Math.Pow).

Console.WriteLine("=== CALCULADORA DE POTENCIA===");

//Captura de datos
Console.Write("Ingrese el numero base (x): ");
int x = int.Parse(Console.ReadLine());

Console.Write("Ingrese el exponente (Y): ");
int y = int.Parse(Console.ReadLine());

int resultado = 1;
int exponente = 0;

//Ciclo
while (exponente < y )
{
    resultado *= x;
    exponente++;
}

//Salida
Console.WriteLine($"la potencia de {x}^{y} = {resultado}");