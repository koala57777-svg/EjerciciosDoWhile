int contador = 0;
double numeroIngresado = 0;

do
{
    Console.WriteLine("Ingrese un número (Ingrese 0 para saber cuantos número se ingresaron): ");
    Console.WriteLine();
    numeroIngresado = double.Parse(Console.ReadLine());
    contador++;
    Console.WriteLine();
} while (numeroIngresado != 0);
Console.WriteLine($"La cantidad de números que se ingresaron fueron de: {contador}");