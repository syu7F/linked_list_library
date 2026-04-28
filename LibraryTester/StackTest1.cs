using System;
using LinkedListLibrary;

public static class StackTest
{
    public static void Run()
    {
        var stack = new MyStack<int>();

        Console.WriteLine("Pushing elements");
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine("Count: " + stack.Count);

        Console.WriteLine("Peek: " + stack.Peek());

        Console.WriteLine("Pop: " + stack.Pop());
        Console.WriteLine("Pop: " + stack.Pop());

        Console.WriteLine("Count after pops: " + stack.Count);

        Console.WriteLine("Remaining elements:");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }
}