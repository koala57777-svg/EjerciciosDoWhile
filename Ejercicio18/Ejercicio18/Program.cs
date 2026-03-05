int opcion = -1;


do
{
    Console.WriteLine();
    Console.WriteLine("Elija una opción: ");
    Console.WriteLine();
    Console.WriteLine("1. Mostrar saludo");
    Console.WriteLine("2. Mostrar número aleatorio");
    Console.WriteLine("3. Salir");
    Console.WriteLine();
    opcion = int.Parse(Console.ReadLine());
    Console.WriteLine();

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Hola, ¿que tal?");
            
            break;
        case 2:
            Random rnd = new Random();
            int numero = rnd.Next(57, 5777);
            Console.WriteLine($"Número aleatorio: {numero}");
            
            break;
        case 3:
            break;
        default:
            Console.WriteLine("Opción no válida. Elija un número entre 1 y 3.");
            
            break;
    }
} while (opcion != 3);
Console.WriteLine("Saliendo del programa...");