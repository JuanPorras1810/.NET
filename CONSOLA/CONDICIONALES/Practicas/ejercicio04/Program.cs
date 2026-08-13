//Verificacion de mayoria de edad: Solicite la edad y muestre "Es mayor de edad" si tiene 18 años o más.

Console.WriteLine("=== VERIFICADOR DE MAYORIA DE EDAD ===");

//Captura de datos
Console.Write("Ingresa tu edad: ");
int edad = int.Parse(Console.ReadLine());

//Condicional
if (edad >= 18)
{
    Console.WriteLine("Es mayor de edad");
}
