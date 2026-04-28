using System;
using MyBinaryTreeProj;

public static class BinaryTreeTest
{
    public static void Run()
    {
        Console.WriteLine("=== Binary Tree Test ===");

        var tree = new BinaryTree<int>();


        Console.WriteLine("Adding elements...");
        tree.Add(10);
        tree.Add(5);
        tree.Add(15);
        tree.Add(3);
        tree.Add(7);

        Console.WriteLine("Count: " + tree.Count);


        Console.WriteLine("In-order traversal (should be sorted):");
        foreach (var item in tree)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

      
        Console.WriteLine("Contains 7: " + tree.Contains(7));  
        Console.WriteLine("Contains 100: " + tree.Contains(100)); 

     
        Console.WriteLine("Removing 3 (leaf): " + tree.Remove(3));

        Console.WriteLine("Removing 5 (one child): " + tree.Remove(5));

        Console.WriteLine("Removing 10 (two children): " + tree.Remove(10));

        Console.WriteLine("Count after removals: " + tree.Count);

        Console.WriteLine("Tree after removals:");
        foreach (var item in tree)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Removing 999 (not exists): " + tree.Remove(999));

        Console.WriteLine("Clearing tree...");
        tree.Clear();

        Console.WriteLine("Count after clear: " + tree.Count);

        Console.WriteLine("Traversal after clear:");
        foreach (var item in tree)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\n");
    }
}