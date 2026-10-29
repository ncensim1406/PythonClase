using System;
using System.Globalization;

class Program
{
    static void Main (string [] arg)
    {
        int[] array = new int[5];
        for(int i =0; i < array.Length; i++)
        {
            Console.WriteLine("Dame un numero ya: ");
            array[i] = int.Parse(Console.ReadLine());
        }
        foreach(int a in array)
        {
            Console.Write($"{a} , ");
        }
        
    }
}