Console.Write("Ingresa numero del dia (1-7): ");
int dia = int.Parse(Console.ReadLine());

string nombreDia = dia switch
{
    1 => "Lunes",
    2 => "Martes",
    3 => "Miercoles",
    4 => "Jueves",
    5 => "Viernes",
    6 => "Sabado",
    7 => "Domingo",
    _ => "Numero invalido"
};
Console.WriteLine(nombreDia);