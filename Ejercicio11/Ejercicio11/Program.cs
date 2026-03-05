double suma = 0;
int numero = 1;
double numeroIngresado = 0;
do
{
    Console.WriteLine($"Ingrese el {numero}° número: ");
    Console.WriteLine();
    numeroIngresado = double.Parse(Console.ReadLine());
    suma += numeroIngresado;
    numero++;
    Console.WriteLine();
} while (numero <= 5);
Console.WriteLine($"La suma total es: {suma}");