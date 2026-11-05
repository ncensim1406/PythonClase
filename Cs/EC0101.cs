using System;

class Program
{
    static int Fibonacci(int n)
    {
        if (n <= 0) return 0;
        if (n == 1) return 1;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        int n = 7;
        Console.WriteLine($"El término {n} de Fibonacci es: {Fibonacci(n)}");
    }
}
