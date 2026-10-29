using System;
using System.Globalization;

class Program
{
    static void Main (string [] arg)
    {
        
        string palabra="reconocer";
        string comprobacion=new string(palabra.Reverse().ToArray());

        if (palabra.Equals(comprobacion))
        {
            Console.WriteLine("Son palindromos");
        }
        else
        {
            Console.WriteLine("No son palindromos");
        }
        
    }
}