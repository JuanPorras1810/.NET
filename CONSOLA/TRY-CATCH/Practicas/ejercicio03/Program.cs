//Division segura con try-catch: Pida dos números y divídalos. Capture división por cero y formato inválido.

Console.WriteLine("=== DIVISION ===");

//Try-catch
try
{
    Console.Write("Ingrese el dividendo: ");
    double dividendo = double.Parse(Console.ReadLine());

    Console.Write("Ingrese el divisor: ");
    double divisor = double.Parse(Console.ReadLine());

    if (divisor == 0)
    {
        throw new DivideByZeroException();
    }

    double resultado = dividendo / divisor;

    Console.WriteLine($"Resultado: {dividendo} / {divisor} = {resultado:F3}");

}
catch (FormatException)
{
    Console.WriteLine("Debe ingresar un numero");
}
catch (DivideByZeroException)
{
    Console.WriteLine("No se puede dividir entre 0");
}