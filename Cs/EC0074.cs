using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main (string [] arg)
    {
        List<int> array = new List<int>();
        bool continuar=true;
        while (continuar)
        {
            Console.WriteLine("1 - Agregar un numero");
            Console.WriteLine("2 - Listar");
            Console.WriteLine("3 - Mostrar media");
            Console.WriteLine("4 - Salir");
            int eleccion = int.Parse(Console.ReadLine());

            switch (eleccion)
            {
                case 1:
                    Console.WriteLine("Introduzca el numero: ");
                    array.Add(int.Parse(Console.ReadLine()));
                break;
                case 2:
                    foreach(int num in array)
                    {
                        Console.Write($"{num} / ");
                    }
                break;
                case 3:
                    int cont=0;
                    int total=0;
                    foreach(int num in array)
                    {
                        cont+=1;
                        total+=num;
                    }
                    Console.WriteLine($"Media es de : {total/cont}");
                break;
                case 4:
                    continuar=false;
                break;
            }
        }
        
    }
}