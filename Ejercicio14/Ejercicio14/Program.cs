double mayornumero=-999999999;
double numeroIngresado = -1;

do
{
    Console.WriteLine("Ingrese un número (Ingrese 0 para saber cual fue el mayor número): ");
    Console.WriteLine();
    numeroIngresado = double.Parse(Console.ReadLine());
    Console.WriteLine();
    if (numeroIngresado > mayornumero)
    {
        mayornumero = numeroIngresado;
    }
} while (numeroIngresado != 0);
Console.WriteLine($"El mayor número ingreasdo fue: {mayornumero}");
