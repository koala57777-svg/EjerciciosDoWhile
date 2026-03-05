int numero = 1;

do
{
    if (numero % 2 == 0)
    {
        Console.WriteLine($" {numero} es par");
    }
    else
    {
        Console.WriteLine($" {numero} es impar");
    }
    Console.WriteLine();
    numero++;
} while (numero <= 20);