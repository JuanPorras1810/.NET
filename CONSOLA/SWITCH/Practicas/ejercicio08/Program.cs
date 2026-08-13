//Nivel de riesgo: Según una puntuación (1-10), determine el nivel de riesgo (Bajo, Medio, Alto).

Console.WriteLine("=== EVALUADOR DE RIESGOS ===");

//Captura de datos
Console.Write("Ingrese la puntuacion (1-10): ");
int numero = int.Parse(Console.ReadLine());

//Switch
string riesgo = numero switch
{ 
    >= 1 and <= 3 => "Bajo",
    >= 4 and <= 7 => "Medio",
    >= 8 and <= 10 => "Alto",
    _=> "Puntuacion no valida"
};

//Salida
Console.WriteLine($"Nivel de riesgo: {riesgo}");