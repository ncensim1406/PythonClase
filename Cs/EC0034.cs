using System;
using System.Globalization;

class Program
{
    static void Main (string [] arg)
    {
        string nombre = "ustedes";
        if(nombre != null)
        {
            Console.WriteLine($"{nombre.First()}{nombre.Last()}");
        }
        
    }
}