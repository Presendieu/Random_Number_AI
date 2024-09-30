/// Presendieu Olando
///  Ce prgramme est un console app qui permet d'afficher une liste croissante de nombre
///


using System;

public class Node<T>
{
    public T Value { get; set; }
    public Node<T> Next { get; set; }

    public Node(T value)
    {
        Value = value;
        Next = null;
    }
}

class Program
{
    static Node<int> InsertNodeSorted(Node<int> head, int value)
    {
        Node<int> newNode = new Node<int>(value);
        if (head == null || head.Value >= value)
        {
            newNode.Next = head;
            return newNode;
        }
        else
        {
            Node<int> current = head;
            while (current.Next != null && current.Next.Value < value)
            {
                current = current.Next;
            }
            newNode.Next = current.Next;
            current.Next = newNode;
            return head;
        }
    }

    static void PrintNodes(Node<int> head)
    {
        while (head != null)
        {
            Console.Write(head.Value + " ");
            head = head.Next;
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Node<int> head = null;
        Random random = new Random();

        int nombre = 21;
        for (int i = 0; i < nombre; i++)
        {
            int value = random.Next(1, 101); 
            head = InsertNodeSorted(head, value);
        }

        Console.WriteLine("Liste d'éléments triés:");
        PrintNodes(head);
    }
}
