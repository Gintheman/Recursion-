using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Элементы массива в обратном порядке:");
        PrintArrayReversed(array, array.Length - 1);
    }

    static void PrintArrayReversed(int[] arr, int i)
    {
        if (i >= 0)
        {
            Console.WriteLine(arr[i]);
            PrintArrayReversed(arr, i - 1);
        }
    }
}

