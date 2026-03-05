double numeroIngresado = 0;
double suma = 0;
int contador = 0;

do
{
    Console.WriteLine();
    Console.WriteLine("Ingrese un número (Ingrese 0 para mostrar resultados): ");
    Console.WriteLine();
    numeroIngresado = double.Parse(Console.ReadLine());
    Console.WriteLine();
    suma += numeroIngresado;
    if (numeroIngresado != 0)
    {
        contador++;
    }
} while (numeroIngresado != 0);
Console.WriteLine();
Console.WriteLine("Los resultados de los números ingresados: ");
Console.WriteLine();
Console.WriteLine($"La suma total de los números: {suma}");
Console.WriteLine();
Console.WriteLine($"La cantidad de números que se ingresaron fueron: {contador}");
Console.WriteLine();
Console.WriteLine($"El promedio de los número ingresado es: {(suma/contador)}");