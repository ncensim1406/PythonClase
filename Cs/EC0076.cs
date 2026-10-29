using System;
using System.Globalization;

class Rafael
{
    static void Main (string [] arg)
    {
        Console.WriteLine($"Introduzca un numero de una cifra : ");
        int numero = int.Parse(Console.ReadLine());
        switch (numero)
        {
            case 1:
                Console.WriteLine("Uno");
                break;
            case 2:
                Console.WriteLine("Dos");
                break;
            case 3:
                Console.WriteLine("Tres");
                break;
            case 4:
                Console.WriteLine("Cuatro");
                break;
            case 5:
                Console.WriteLine("Cinco");
                break;
            case 6:
                Console.WriteLine("Seis");
                break;
            case 7:
                Console.WriteLine("Siete");
                break;
            case 8:
                Console.WriteLine("Ocho");
                break;
            case 9:
                Console.WriteLine("Nueve");
                break;
            case 0:
                Console.WriteLine("Cero");
                break;
            default:
                Console.WriteLine("No ha introducido un numero valido");
                break;
        }
    }
}