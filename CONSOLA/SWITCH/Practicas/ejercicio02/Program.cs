Console.Write("ingrese el valor 1: ");
double valor1 = Convert.ToDouble(Console.ReadLine());

Console.Write("ingrese el operador(+,-,*,/): ");
string operador = Console.ReadLine();

Console.Write("ingrese el valor 2: ");
double valor2 = Convert.ToDouble(Console.ReadLine());

double resultado = 0;

switch (operador)
{
    case "+":
        Console.WriteLine(valor1 + valor2);
        break;

    case "-":
        Console.WriteLine(valor1 - valor2);
        break;

    case "*":
        Console.WriteLine(valor1 * valor2);
        break;

    case "/":
        if (valor2 == 0)

        {

        }
        Console.WriteLine(valor1 + valor2);
        break;

    default:
}