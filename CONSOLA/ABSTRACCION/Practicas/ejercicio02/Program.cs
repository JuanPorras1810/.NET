//Interface ICalculable: Interface con metodo CalcularTotal(). Producto y Servicio lo implementan.

using ejercicio02;

Console.WriteLine("=== CALCULAR PRECIO ===");

//Objetos para las operaciones
Producto pro = new Producto();
Servicio ser = new Servicio();

//Bucle infinito para elegir la opcion
while (true)
{
    Console.Write("Ingrese 1 para producto o 2 para servicio: ");
    if (int.TryParse(Console.ReadLine(), out int opcion))
    {
        //Validaciones para opcion 1 
        if (opcion == 1)
        {
            while (true)
            {
                Console.Write("Ingrese cantidad producto: ");
                if (int.TryParse(Console.ReadLine(), out int can))
                {
                    if (can > 0)
                    {
                        pro.Cantidad = can;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("El producto debe ser positivo");
                    }
                   
                }
                else
                {
                    Console.WriteLine("Cantidad no valida...");
                }
            }

            while (true)
            {
                Console.Write("Ingrese precion del producto: ");
                if (int.TryParse(Console.ReadLine(), out int pre))
                {
                    if (pre > 0)
                    {
                        pro.Precio = pre;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("El precio debe ser positivo");
                    }
                }
                else
                {
                    Console.WriteLine("Precio no valida...");
                }
            }
            Console.WriteLine($"Total a pagar por productos: {pro.CalcularTotal()}");
        }

        //Validaciones para opcion 2
        else if (opcion == 2)
        {
            while (true)
            {
                Console.Write("Ingrese cantidad horas: ");
                if (int.TryParse(Console.ReadLine(), out int hor))
                {
                    if (hor > 0)
                    {
                        ser.Hora = hor;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("La cantidad de horas deben ser positivas...");
                    }

                }
                else
                {
                    Console.WriteLine("Cantidad no valida...");
                }
            }

            while (true)
            {
                Console.Write("Ingrese el precion por hora: ");
                if (int.TryParse(Console.ReadLine(), out int pre1))
                {
                    if (pre1 > 0)
                    {
                        ser.Precio = pre1;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("El precio debe ser positivo");
                    }
                }
                else
                {
                    Console.WriteLine("Precio no valida...");
                }
            }
            Console.WriteLine($"Total a pagar por el servicio: {ser.CalcularTotal()}");
        }
        else
        {
            Console.WriteLine("Opcion no valida...");
        }
    }
    else
    {
        Console.WriteLine("Error, solo se permite numeros");
    }
}

