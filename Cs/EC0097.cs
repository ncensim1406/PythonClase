using System.Collections.Generic;
using System;
class Program
{
    static void Main(string[] args)
    {
        int[] lista = new int[20];
        for(int i = 0 ; i<20;i++)
        {
            Console.WriteLine($"Introduzca un entero");
            int palabra= int.Parse(Console.ReadLine());
            lista[i]=palabra;
            
        }
        Console.WriteLine(string.Join(", ",lista));
        BubbleSort(lista);
        Console.WriteLine(string.Join(", ",lista));

        
    }
    static void BubbleSort(int[] arreglo)
    {
        int n = arreglo.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arreglo[j] > arreglo[j + 1])
                {
                    int temp = arreglo[j];
                    arreglo[j] = arreglo[j + 1];
                    arreglo[j + 1] = temp;
                }
            }
        }
    }

}