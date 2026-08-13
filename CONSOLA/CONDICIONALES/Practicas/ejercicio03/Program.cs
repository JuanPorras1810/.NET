//Si la compra supera $100,000 hay 15% de descuento. si no, no hay descuento

Console.Write("Ingresa el valor de la compra: ");
double ValCom = Convert.ToDouble(Console.ReadLine());

if (ValCom>100000)
{
    double descuento = (ValCom * 0.15);
    double total = (ValCom - descuento);
    Console.WriteLine($"Por la compra de ${ValCom} tienes un descuento del 15%: {descuento} ");
    Console.WriteLine($"Total a pagar: ${total}");
}
else
{
    Console.WriteLine("No tienes descuento");
    Console.WriteLine($"Total a pagar: ${ValCom}");
}


