Console.Write("Ingresa el nombre del aprendiz: ");
string nombre = Console.ReadLine();

Console.Write($"Ingresa la nota del aprendiz {nombre}: ");
double nota = Convert.ToDouble(Console.ReadLine());

if (nota>=75)
{
    Console.WriteLine($"El aprendiz {nombre} esta aprobado");
}
else
{
    Console.WriteLine($"El aprendiz {nombre} NO esta aprobado");
}
Console.WriteLine("Chaito");