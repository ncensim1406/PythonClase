using System;
using System.Globalization;

class Program
{
    static void Main (string [] arg)
    {
        bool correcto = false;
        int a;
        do
        {
            Console.WriteLine("Introduce un numero entero porfa");
            correcto = int.TryParse(Console.ReadLine(),out a);
            if(correcto){
                Console.WriteLine("Muchas glasias");
            }
        }while(!correcto);
    }
}