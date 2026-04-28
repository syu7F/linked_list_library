using System;
using MyBubbleSort;

public static class MyBubbleSortTest
{
    public static void Run()
    {
        var sorter = new MyBubbleSort<int>();

        int[] numbers = { 5, 3, 8, 4, 2 };

        Console.WriteLine("Before sorting:");
        PrintArray(numbers);

        sorter.Sort(numbers);

        Console.WriteLine("After sorting:");
        PrintArray(numbers);
    }

    static void PrintArray<T>(T[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}