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

        Console.Write("Introduce el número del mes (1-12): ");
        int mes2 = int.Parse(Console.ReadLine());

        Console.Write("Introduce el número del día: ");
        int dia2 = int.Parse(Console.ReadLine());

        int diaDelAño2 = 0;

        for (int i = 0; i < mes2 - 1; i++)
        {
            diaDelAño2 += diasPorMes[i];
        }

        diaDelAño2 += dia2;
        int diferencia = diaDelAño-diaDelAño2;
        if (diferencia < 0)
        {
            diferencia=diferencia*-1;
        }
        Console.WriteLine($"El día {dia} del mes {mes} corresponde al Día {diaDelAño} del año.");
        Console.WriteLine($"El día {dia2} del mes {mes2} corresponde al Día {diaDelAño2} del año.");
        Console.WriteLine($"Entre los dos dias hay una diferencia de {diferencia} dias.");
    }
}
