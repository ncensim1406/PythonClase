using System;
using System.Globalization;

class Program
{
    static void Main (string [] arg)
    {
        string[] array = new string[]{"Hola","cola","cocacola","hola","Hola"};
        int cont =0;
        foreach(string nombre in array)
        {
            cont+=1;
            for(int i=cont; i < array.Length; i++)
            {
                if (nombre == array[i])
                {
                    Console.WriteLine($"Elemento {nombre} duplicado!");
                }
            }
        }
        HashSet<string> forma2 = new HashSet<string>();

        foreach(string nombre in array)
        {
            if (!forma2.Add(nombre))
            {
                Console.WriteLine($"Elemento {nombre} duplicado!");
            }
        }

        if(array.Distinct().Count() != array.Length){
            Console.WriteLine($"Elemento duplicado!");
        }
        
    }
}