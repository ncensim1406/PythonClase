using System;
using System.Globalization;

class Program
{
    static void Main (string [] arg)
    {
        Console.WriteLine($"Introduzca un numero: ");
        double a = double.Parse(Console.ReadLine());
        double redondeadoA = Math.Ceiling(a);
        double redondeadoB = Math.Floor(a);

        Console.WriteLine($"El numero redondeado 1 : {redondeadoA} y el otro es {redondeadoB}");
        
    }
}