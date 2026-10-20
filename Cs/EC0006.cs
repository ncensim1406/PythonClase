using System;
using System.Globalization;

class Programa
{
    static void Main(string[] args)
    {
        double entero1 = 321;
        double entero2 = 698;
        double result = entero2/entero1;
        Console.WriteLine($"El resultado es:  {result:F3}");
    }
}