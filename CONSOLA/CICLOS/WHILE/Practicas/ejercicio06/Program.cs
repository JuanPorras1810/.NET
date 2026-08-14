//Menu de opciones multiple: Cree un menú con 5 opciones que se repita hasta elegir 'Salir'.

//Ciclo
while (true)
{
    Console.WriteLine("=== MENU ===");
    Console.WriteLine("1. Inicio");
    Console.WriteLine("2. Ver perfil");
    Console.WriteLine("3. Notificaciones");
    Console.WriteLine("4. Configuracion");
    Console.WriteLine("5. Salir");

    Console.Write("Elija una opcion(1-5):");
    int opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1: 
            Console.WriteLine("Ingreso al inicio...");
            break;

        case 2:
            Console.WriteLine("Ingreso al perfil...");
            break;

        case 3:
            Console.WriteLine("Ingreso a las notificaciones...");
            break;

        case 4:
            Console.WriteLine("Ingreso a la configuracion...");
            break;

        case 5:
            Console.WriteLine("Saliendo del programa...");
            return;


        default:
            Console.WriteLine("Opcion no valida");
            break;
    }
    Console.ReadLine();
    Console.WriteLine("Regresando al menu...");
}