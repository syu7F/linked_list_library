using System;

class Node
{
    public int Value;
    public Node? Left, Right;

    public Node(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}

class BinaryTree
{
    public Node? Root;

    public void Visit(Node? current)
    {
        if (current == null)
            return;

        Console.Write(current.Value + " "); 
        Visit(current.Left);
        Visit(current.Right);
    }

    static void Main(string[] args)
    {
        BinaryTree tree = new BinaryTree();
        tree.Root = new Node(4);
        tree.Root.Left = new Node(2);
        tree.Root.Right = new Node(6);
        tree.Root.Left.Left = new Node(1);
        tree.Root.Left.Right = new Node(3);
        tree.Root.Right.Left = new Node(5);
        tree.Root.Right.Right = new Node(7);

        Console.Write("Pre-Order: ");
        tree.Visit(tree.Root);
        Console.ReadLine();
    }

}

