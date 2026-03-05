Console.WriteLine(" Ingrese un número para crear su tabla de multiplicar: ");
Console.WriteLine();
int numero=int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($" La tabla del {numero}");
Console.WriteLine();
int multiplo = 1;
do
{
    Console.WriteLine($" {numero} x {multiplo} = {numero * multiplo}");
    Console.WriteLine();
    multiplo++;
} while (multiplo <= 10);