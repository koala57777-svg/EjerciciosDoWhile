double numeroIngresado = 0;

do
{
    Console.WriteLine("Ingrese un número positivo: ");
    Console.WriteLine();
    numeroIngresado = double.Parse(Console.ReadLine());
    Console.WriteLine();
} while (numeroIngresado <= 0);
Console.WriteLine("Número válido");