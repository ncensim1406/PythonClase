using System;
using System.Globalization;

class Program
{
    static void Main (string [] arg)
    {
        Console.WriteLine($"Introduzca un numero: ");
        double a = double.Parse(Console.ReadLine());

        if(a >=10 && a <= 50)
        {
            Console.WriteLine("Si esta entre 10 y 50");
        }
        else
        {
            Console.WriteLine("No esta entre 10 y 50");
        }
        
    }
}