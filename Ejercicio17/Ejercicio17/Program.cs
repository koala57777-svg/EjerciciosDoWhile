int contador = 0;
int numeroIngresado = 0;

do
{
    Console.WriteLine("Ingrese un número (Ingrese 0 para saber cuantos son pares): ");
    Console.WriteLine();
    numeroIngresado=int.Parse(Console.ReadLine());
    Console.WriteLine();
    if (numeroIngresado % 2 == 0 && numeroIngresado!=0)
    {
        contador++;
    }
}while (numeroIngresado!=0);
Console.WriteLine($"La cantidad de número pares ingresados fueron: {contador}");