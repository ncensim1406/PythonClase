using System;
using System.Globalization;

class Program
{
    static void Main (string [] arg)
    {
        int [] n = new int[] { 1,3,4,6,21,4,12,4};
        int total=0;
        for (int i =0; i < n.Length ; i++)
        {
            total+=n[i];
        }
        Console.WriteLine($"El primer total es : {total}");
        total=0;
        foreach(int a in n)
        {
            total+=a;
        }
        Console.WriteLine($"El segundo total es : {total}");
    }
}