using System;
using System.Globalization;

class Programa
{
    static void Main(string[] args)
    {
        int a = 3;
        int b = a+1+1;
        int c = b*3;
        a = a*2;
        Console.WriteLine($"El resultado es: {a} {b} {c}");
    }
}