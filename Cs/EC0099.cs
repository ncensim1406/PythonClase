using System.Collections.Generic;
using System;
class Program
{
    static void Main(string[] args)
    {
        int[] array = devolverArray(1,2,3,4,5,6,7);
        Console.WriteLine(string.Join(", ",array));
    }
    
    public static int[] devolverArray(params int[] numeros)
    {
        return numeros;
    }

}