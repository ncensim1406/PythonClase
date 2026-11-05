using System.Collections.Generic;
using System;
class Program
{
    static void Main(string[] args)
    {
        int [] array = swap(1,2);
        Console.WriteLine(string.Join(", ",array));
    }
    
    public static int[] swap(int num1,int num2)
    {
        int[] aux = {num2,num1};
        return aux;
    }

}