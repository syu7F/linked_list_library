using System;
using MyInsertionSort;

public static class MyInsertionSortTest
{
    public static void Run()
    {
        var sorter = new MyInsertionSort<int>();

        int[] numbers = { 9, 1, 5, 3, 7 };

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