using System;
class Program
{
    static void Main(string[] args)
    {
        int M = 1;
        int N = 10;

        PrintNumbersInRange(M, N);
    }

    static void PrintNumbersInRange(int start, int end)
    {
        if (start > end)
        {
            return;
        }
        Console.WriteLine(start);
        PrintNumbersInRange(start + 1, end);
    }
}
