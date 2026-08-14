//Validar email con throw: Valide que un email contenga '@' y '.'. Lance excepcion si no es válido.

Console.WriteLine("=== VALIDADOR DE EMAIL ===");

//Try-catch
try
{
	Console.Write("Ingrese su email: ");
	string email = Console.ReadLine();

    if (!email.Contains("@") && !email.Contains("."))
    {
        throw new ArgumentException("El email debe tener @ y .");
    }
    else if (!email.Contains("@"))
	{
		throw new ArgumentException("El email debe tener @");
	}
	else if (!email.Contains("."))
	{
        throw new ArgumentException("El email debe tener .");
    }

	Console.WriteLine("Email valido...");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}