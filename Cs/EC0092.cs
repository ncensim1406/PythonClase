using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduzca una serie de nuemeros enteros separados por una coma");
        string numeros = Console.ReadLine();

        string[] enteros = numeros.Trim().Split(",");
        List<int> listaEnteros = new List<int>();
        foreach(string numero in enteros)
        {
            listaEnteros.Add(int.Parse(numero));
        }
        Console.WriteLine($"{listaEnteros.Max()} Es el maximo valor");
        Console.WriteLine($"{listaEnteros.Min()} Es el minimo valor");
        Console.WriteLine($"{listaEnteros.Sum()} Es la suma total");
    }
}
