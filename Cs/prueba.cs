using System;
using System.Globalization;

class Program
{
    static string name = "";
    static void Main(string[] args)
    {
        double num = 123.1232;
        double porcentaje = 0.1234;

        Console.WriteLine($"{num:F3}");
        Console.WriteLine(num.ToString("F3"));
        Console.WriteLine($"{porcentaje:P2}");

        Console.Write("Ingrese un numero: ");
        string input = Console.ReadLine().Trim();

        int numero = int.Parse(input);

        Console.Write("Ingrese otro numero: ");
        string imput2 = Console.ReadLine().Trim();
        int numero2 = int.TryParse(imput2, out int result) ? result : 0;

        Console.WriteLine($"El primer numero es {numero} y el segundo es {numero2}");
    }
}