using System;
using System.Collections.Generic;

class Program 
{ 
    static void Main(string[] args) 
    { 
        string arr = "hola que tal";
        string[] array = devolverArray(arr); 

        Console.WriteLine(string.Join("", array)); 
    } 

    public static string[] devolverArray(string cadena) 
    { 
        string[] aux = new string[cadena.Length];
        
        for(int i = 0; i < cadena.Length; i++)
        {
            aux[i] = cadena[cadena.Length - 1 - i].ToString();
        }
        
        return aux; 
    } 
}
