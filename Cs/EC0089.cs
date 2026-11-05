using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main (string [] arg)
    {
        List<int> numeros = new List<int>();
        double total=0;
        double media;
        int mayor=0;
        int numeromasrepetido=0;
        for(int i =0;i < 10; i++)
        {
            Console.WriteLine($"Introduce un numero entero porfavor");
            int numero = int.Parse(Console.ReadLine());
            total+=numero;
            numeros.Add(numero);
        }
        media = total/10;
        Console.WriteLine($"La media es de {media}");
        foreach(int numero in numeros)
        {
            if (numero < media)
            {
                Console.Write($"{numero}, ");
            }
            int repeticiones = numeros.Count(n => n == numero);
            if (mayor < repeticiones)
            {
                mayor=repeticiones;
                numeromasrepetido=numero;
            }
        }
        Console.WriteLine($"El numero mas repetido es: {numeromasrepetido} , repetido {mayor} veces");
        
    }
}