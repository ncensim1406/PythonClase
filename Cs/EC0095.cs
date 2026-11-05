using System.Collections.Generic;
using System;
class Program
{
    static void Main(string[] args)
    {
        int cont = 1;
        List<string> lista = new List<string>();
        while (true)
        {
            if (cont == 100)
            {
                break;
            }
            Console.WriteLine($"Introduzca una palabra");
            string palabra= Console.ReadLine();
            if (palabra == "")
            {
                break;
            }
            lista.Add(palabra);
            lista.Sort();
            cont++;
            
        }
        Console.WriteLine(string.Join(", ",lista));

        
    }
}