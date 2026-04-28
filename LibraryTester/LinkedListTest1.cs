using System;
using LinkedListLibrary;

public static class LinkedListTest
{
    public static void Run()
    {
        Console.WriteLine("=== LinkedList Test ===");

        var list = new Mylinkedlist<int>();

        // 🔹 AddFirst
        Console.WriteLine("AddFirst:");
        list.AddFirst(10);
        list.AddFirst(20);
        list.AddFirst(30);

        Print(list);

        Console.WriteLine("Count: " + list.Count);

        // 🔹 AddLast
        Console.WriteLine("AddLast:");
        list.AddLast(100);
        list.AddLast(200);

        Print(list);

        // 🔹 RemoveFirst
        Console.WriteLine("RemoveFirst:");
        list.RemoveFirst();
        Print(list);

        // 🔹 RemoveLast
        Console.WriteLine("RemoveLast:");
        list.RemoveLast();
        Print(list);

        // 🔹 Contains (IMPORTANT: cast needed)
        Console.WriteLine("Contains 100: " + ((ICollection<int>)list).Contains(100));
        Console.WriteLine("Contains 999: " + ((ICollection<int>)list).Contains(999));

        // 🔹 Clear
        Console.WriteLine("Clear:");
        list.Clear();
        Print(list);

        Console.WriteLine("Count after clear: " + list.Count);
    }

    static void Print<T>(Mylinkedlist<T> list)
    {
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}