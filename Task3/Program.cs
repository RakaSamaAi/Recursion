using System;

class Program
{
    static void PrintArrayReversed(int[] arr, int index)
    {
        if (index < 0 || index >= arr.Length)
            return;

        Console.Write(arr[index] + " ");

        PrintArrayReversed(arr, index - 1);
    }

    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Элементы массива в обратном порядке:");

        PrintArrayReversed(array, array.Length - 1);
    }
}
