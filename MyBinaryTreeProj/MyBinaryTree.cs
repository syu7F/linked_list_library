using System.Collections;
namespace MyBinaryTreeProj;

public class BinaryTree<T>: IEnumerable<T>
     where T : IComparable<T>
{
    private BinaryTreeNode<T>? _head;
    private int _count;

    #region Add
    public void Add(T value)
    {
        BinaryTreeNode<T> newNode = new BinaryTreeNode<T>(value);

        if (_head == null)
        {
            _head = newNode;
            _count++;
            return;
        }

        BinaryTreeNode<T> current = _head;

        while (true)
        {
            int result = value.CompareTo(current.Value);

            if (result < 0)
            {
                if (current.Left == null)
                {
                    current.Left = newNode;
                    break;
                }
                current = current.Left;
            }

            else
            {
                if (current.Right == null)
                {
                    current.Right = newNode;
                    break;
                }
                current = current.Right;
            }
        }

        _count++;
    }

    #endregion Add

    public bool? Contains(T value)
    {
        if (_head == null)
            return null;

        return Contains(_head, value);
    }

    private bool Contains(BinaryTreeNode<T> node, T value)
    {
        int result = value.CompareTo(node.Value);

        if (result == 0)
            return true;

        if (result < 0)
        {
            if (node.Left == null)
                return false;

            return Contains(node.Left, value);
        }
        else
        {
            if (node.Right == null)
                return false;

            return Contains(node.Right, value);
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}