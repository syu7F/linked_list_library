using System;
using LinkedListLibrary;

class MyPriorityQueueTest
{
    static void Main()
    {
        var pq = new PriorityQueue<int>();

        Console.WriteLine("ENQUEUE TEST");
        pq.Enquene(5);
        pq.Enquene(1);
        pq.Enquene(3);
        pq.Enquene(10);

        Console.WriteLine("Count: " + pq.Count);

        Console.WriteLine("\nPRIORITY ORDER TEST");
        while (pq.Count > 0)
        {
            Console.WriteLine(pq.Dequeue());
        }

        Console.WriteLine("\nEMPTY TEST");
        try
        {
            pq.Dequeue();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}