using System;
using MyQueue = MyQueueProject.Queue<int>;


public static class QueueTest
{
    public static void Run()
    {
        Console.WriteLine("=== Queue Test ===");

        var queue = new Queue<int>();

        Console.WriteLine("Enqueue elements:");
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Console.WriteLine("Count: " + queue.Count());

        Console.WriteLine("Peek: " + queue.Peek());

        Console.WriteLine("Dequeue: " + queue.Dequeue());
        Console.WriteLine("Dequeue: " + queue.Dequeue());

        Console.WriteLine("Count after dequeue: " + queue.Count());

        Console.WriteLine("Remaining elements:");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }

    
        Console.WriteLine("Clearing queue...");
        queue.Clear();

        Console.WriteLine("Count after clear: " + queue.Count());

        try
        {
            queue.Dequeue(); 
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Exception caught: " + ex.Message);
        }

        Console.WriteLine();
    }
}