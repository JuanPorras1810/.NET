//Dia con or: Use el operador 'or' para agrupar dias de la semana en categorias.

Console.WriteLine("=== AGENDA DE LA SEMANA ===");

//Captura de datos
Console.Write("Ingrese un dia de la sema (1-7): ");
int dia = int.Parse(Console.ReadLine());

//Switch
string agenda = dia switch 
{
    1 => "Planeacion de proyecto",
    2 or 3 => "Armar y codificar el proyecto",
    4 or 5 => "Probar y terminar el proyecto",
    6 or 7 => "Descanso",
    _=> "Dia no valido"
};

//Salida
Console.WriteLine($"Actividad: {agenda}");