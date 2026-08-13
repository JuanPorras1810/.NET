//Calcular IVA de una compra: Pida el valor de una compra y calcule el IVA (19%) y el total.

Console.WriteLine("=== CALCULADORA DE IVA ===");

//Captura de datos
Console.Write("Ingrese el valor de la compra: ");
double compra = double.Parse(Console.ReadLine());

//Proceso
double iva = compra * 0.19;
double total = compra + iva;

//Salida
Console.WriteLine($"Tu compra de ${compra} + ${iva} de IVA (19%) da un total de: $ {total}");