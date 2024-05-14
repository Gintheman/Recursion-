using System;

class Program
{
    static void Main(string[] args)
    {
        int M = 1; // начальное значение
        int N = 10; // конечное значение

        Console.WriteLine($"Натуральные числа в промежутке от {M} до {N}:");
        PrintNaturalNumbers(M, N);
    }

    static void PrintNaturalNumbers(int start, int end)
    {
        if (start <= end)
        {
            Console.WriteLine(start);
            PrintNaturalNumbers(start + 1, end);
        }
    }
}
