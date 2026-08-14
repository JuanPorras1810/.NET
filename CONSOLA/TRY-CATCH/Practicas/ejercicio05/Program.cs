//Finally siempre se ejecuta: Demuestre que finally se ejecuta tanto con error como sin error.

Console.WriteLine("=== PRUEBA DE FUNCIONAMIENTO ===");
Console.WriteLine("Numero: Muestra el try\nLetra: Muestra el catch\nFinally: Simpre se ejecuta");

//Try-catch
try
{
    Console.Write("Ingresa un numero o letra: ");
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine("Uso try...");
}
catch (Exception ex)
{
    Console.WriteLine("Uso catch...");
    Console.WriteLine("Error: " + ex.Message);
}
finally
{
    Console.WriteLine("Uso finally...");
}