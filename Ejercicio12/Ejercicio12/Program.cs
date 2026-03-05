double suma = 0;
double numeroIngresado = 0;

do
{
    Console.WriteLine();
    Console.WriteLine("Ingrese un número (Ingrese 0 para mostrar la suma total): ");
    Console.WriteLine();
    numeroIngresado = double.Parse(Console.ReadLine());
    suma += numeroIngresado;
} while (numeroIngresado != 0);
Console.WriteLine();
Console.WriteLine($"La suma tota es: {suma}");