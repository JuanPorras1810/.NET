//IMC con Ternario: Calcule IMC y use ternario para decir "Saludable" o "Riesgo".

Console.WriteLine("=== CALCULADORA DE IMC ===");

//Captura de datos
Console.Write("Ingrese su peso en (kg): ");
double peso = double.Parse(Console.ReadLine());

Console.Write("Ingrese su altura en (m): ");
double altura  = double.Parse(Console.ReadLine());

//Proceso
double imc = (peso / (altura * altura));
string estado = (imc > 25) ? "Riesgo" : "Saludable";

//Salida
Console.WriteLine($"Tu IMC es de {imc} Kg/m^2 por lo que estas en un estado {estado}");