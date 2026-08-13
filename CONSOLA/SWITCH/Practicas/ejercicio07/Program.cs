//Tipo de vehiculo: Según la placa (M=moto, C = carro, B = bus), muestre el tipo de vehículo.

using System.Timers;

Console.WriteLine("=== TIPO DE VEHICULO POR PLACA ===");

//Captura de datos
Console.Write("Ingrese la placa (M, C, B): ");
char placa = char.Parse(Console.ReadLine().ToUpper());

//Switch
string tipo = placa switch
{
    'M'=> "Moto",
    'C'=> "Carro",
    'B'=> "Bus",
    _ => "No registrado"
};

//Salida
Console.WriteLine($"Vehiculo: {tipo}");
