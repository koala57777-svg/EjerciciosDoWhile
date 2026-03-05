using System.Diagnostics.Contracts;
string contra;
do
{
    Console.WriteLine("Ingrese su contraseña: ");
    Console.WriteLine();
    contra = Console.ReadLine();
    Console.WriteLine();
} while (contra != "koala");
Console.WriteLine("Contraseña correcta");