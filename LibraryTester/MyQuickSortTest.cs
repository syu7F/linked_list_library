using System;
using MyQuickSortProject;

namespace QuickSortTest
{
    public class MyQuickSortTest
    {
        public static void Run()
        {
            MyQuickSort<int> sorter = new MyQuickSort<int>();

            int[] numbers = { 8, 3, 1, 7, 0, 10, 2 };

            Console.WriteLine("Մինչ sort-ը:");
            PrintArray(numbers);

            sorter.Sort(numbers);

            Console.WriteLine("\nSort-ից հետո:");
            PrintArray(numbers);
        }

        private static void PrintArray<T>(T[] items)
        {
            foreach (T item in items)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}