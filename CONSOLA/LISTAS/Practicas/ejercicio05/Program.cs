//Lista de estudiantes: Cree una clase Estudiante y una lista con 5 estudiantes. Muestre el promedio del curso.

using ejercicio05;

Console.WriteLine("=== PROMEDIO DEL CURSO ===");

//Lista
List<Estudiante> promedio = new List<Estudiante>();
promedio.Add(new Estudiante { Nombre = "Juan", Nota = 10 });
promedio.Add(new Estudiante { Nombre = "Carlos", Nota = 2.5 });
promedio.Add(new Estudiante { Nombre = "Stiven", Nota = 9 });
promedio.Add(new Estudiante { Nombre = "Brayan", Nota = 5 });

//Salida
double nota = 0;
double numero = 1;
Console.WriteLine("\n--------------------------\n");
foreach (var item in promedio)
{
    Console.WriteLine($"Estudiante {numero}: {item.Nombre}");
    Console.WriteLine($"Nota: {item.Nota}");
    Console.WriteLine("\n--------------------------\n");

    nota += item.Nota;
    numero++;
}
Console.WriteLine($"Promedio: {nota / promedio.Count}");