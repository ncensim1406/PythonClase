using System;

class Program
{
    static void Main(string[] args)
    {
        int[] diasPorMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        Console.Write("Introduce el número del mes (1-12): ");
        int mes = int.Parse(Console.ReadLine());

        Console.Write("Introduce el número del día: ");
        int dia = int.Parse(Console.ReadLine());

        int diaDelAño = 0;

        for (int i = 0; i < mes - 1; i++)
        {
            diaDelAño += diasPorMes[i];
        }

        diaDelAño += dia;
        Console.WriteLine($"El día {dia} del mes {mes} corresponde al Día {diaDelAño} del año.");
    }
}
