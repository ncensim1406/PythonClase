using System;
using System.Globalization;

class Program
{
    static void Main (string [] arg)
    {
        Console.WriteLine($"Introduzca un numero: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine($"Introduzca un numero: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Introduzca un numero: ");
        int c = int.Parse(Console.ReadLine());
        int mayor;
        if (a > b && a > c)
        {
            mayor=a;
        }else if (b > a && b > c)
        {
            mayor = b;
        }
        else
        {
            mayor = c;
        }
        Console.WriteLine($"El mayor es : {mayor}");
    }
}