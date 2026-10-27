using System;
using System.Globalization;

class Program
{
    static void Main (string [] arg)
    {
        Console.WriteLine($"Introduzca un numero: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine($"Primer opcion: {Math.Round(a)}, Segunda opcion {Math.Round(a,2)} , Tercera opcion {Math.Truncate(a)}");
        
    }
}