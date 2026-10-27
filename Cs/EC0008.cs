using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int ca = 0;
        bool conversionBien = false;
        do
        {
            Console.WriteLine($"Introduzca un numero");
            string a = Console.ReadLine();
            conversionBien= int.TryParse(a,out ca);
        } while (!conversionBien);
        
        Console.WriteLine($"Introduzca un numero");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Introduzca un numero");
        int c = Convert.ToInt32(Console.ReadLine());
        int resultado = ca+b+c;
        Console.WriteLine($"El resultado es: {resultado}");
    }
}