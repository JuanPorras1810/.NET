//Calculadora con validacion completa: Validar números, operación válida, y división por cero con mensajes específicos.

Console.WriteLine("=== CALCULADORA ===");

//Try-catch
try
{
    Console.Write("Ingrese tipo de operacion(|+|-|*|/|): ");
    string simbolo = Console.ReadLine();

    if (simbolo != "+" && simbolo != "-" && simbolo != "*" && simbolo != "/")
    {
        throw new ArgumentException("Simbolo no valido");
    }

    Console.Write("Ingrese el numero 1: ");
    double num1 = double.Parse(Console.ReadLine());

    Console.Write("Ingrese el numero 2: ");
    double num2 = double.Parse(Console.ReadLine());

    switch (simbolo)
    {
        case "+":
            double suma = num1 + num2;
            Console.WriteLine($"Suma: {num1} + {num2} = {suma}");
            break;

        case "-":
            double resta = num1 - num2;
            Console.WriteLine($"Resta: {num1} - {num2} = {resta}");
            break;

        case "*":
            double multiplicacion = num1 * num2;
            Console.WriteLine($"Multiplicacion: {num1} * {num2} = {multiplicacion}");
            break;

        case "/":
            if (num2 == 0)
            {
                throw new DivideByZeroException();
            }
            double division = num1 / num2;
            Console.WriteLine($"Division: {num1} / {num2} = {division}");
            break;
    }

}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
catch (DivideByZeroException)
{
    Console.WriteLine("No se puede dividir por cero");
}
catch (FormatException)
{
    Console.WriteLine("Solo se admiten numeros");
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex);
}