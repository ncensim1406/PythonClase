using System;
using System.Globalization;

class Program
{
    static void Main (string [] arg)
    {
        string nombre = "ustedes dos";
        string vocales="aeiou"; 
        int total=0;
        foreach(char vocal in nombre)
        {
            if (vocales.Contains(vocal))
            {
                total+=1;
            }
            
        }
        Console.WriteLine($"Hay un total de {total} vocales");
        
    }
}