using System;

namespace ConsoleApp1
{
    class Program
    {
        //T p = default(T);
        public static void PrintSingleLinkedList<T>(Node<T> head)
        {
            if (head == null)
            {
                Console.WriteLine("head -> null");
                return;
            }
            Node<T> p = head;

            Console.Write("head -> ");
            while(p != null)
            {
                Console.Write(p.ToString());
                p = p.Next;
            }
            Console.Write("null");
        }


        public static void AddAtEndOfSingleLinkedList<T>(T element, Node<T> head)
        {
            Node<T> temp = head;
            Node<T> addNode = new Node<T>(element);
            while (temp != null)
            {
                temp.Next = addNode;
            }   
        }





        static void Main(string[] args)
        {
            Node<int> head =
            new Node<int>(2,
                new Node<int>(5,
                    new Node<int>(1)));
            AddAtEndOfSingleLinkedList<int>(-1, head);
            PrintSingleLinkedList<int>(head);
        }
    }



    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node(T data, Node<T> next = null)
        {
            Data = data; Next = next;
        }
        public override string ToString() => (this == null) ? "null" : $"{Data} -> ";
    }

}
