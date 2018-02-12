using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
    }

    public class Node
    {
        public Node(int dataValue)
        {
            Value = dataValue;
            Next = null;
        }
        public int Value { get; set; }
        public Node Next { get; set; }
        public Node Down { get; set; }
    }
    class Program
    {
        public static Node Head;
        public static Node Tail;
        static void Main(string[] args)
        {
            InitSimpleLinkedList();
            
            PrintLinkedList();
            //AddFirst(7);
            //AddLast(10);
            FindMiddle();
            PrintLinkedList();
            Console.ReadKey();
        }

        static void InitComplexLinkedList()
        {
            var firstNode=new Node(5);
            firstNode.Down=new Node(8);
            firstNode.Down.Down=new Node(15);
            firstNode.Down.Down.Down=new Node(12);
                     
            var secondNode=new Node(2);
            secondNode.Down=new Node(21);
            secondNode.Down.Down=new Node(11);
            firstNode.Next = secondNode;

            var thirdNode=new Node(6);
            thirdNode.Down=new Node(22);
            thirdNode.Down.Down=new Node(56);
            thirdNode.Down.Down=new Node(78);
            secondNode.Next = thirdNode;
            Head = firstNode;
        }

        static void InitSimpleLinkedList()
        {
            var firstNode=new Node(1);
            var secondNode=new Node(2);
            firstNode.Next = secondNode;
            var thirdNode= new Node(3);
            secondNode.Next = thirdNode;
            Head = firstNode;
            Tail = thirdNode;

        }

        static void AddFirst(int value)
        {
            Console.WriteLine($"Adding value {value} as the first node.");
            var newFirstnode = new Node(value) {Next = Head};
            Head = newFirstnode;
        }

        static void AddLast(int value)
        {
            Console.WriteLine($"Adding value {value} as the last node.");
            var lastNode=new Node(value);
            Tail.Next = lastNode;
        }

        static void PrintLinkedList()
        {
            var nodeX=Head;
            while (nodeX != null)
            {    
                Console.Write(nodeX.Value + "->");
                nodeX = nodeX.Next;
            }
            Console.Write("NULL \n");
        }

        static void FindMiddle()
        {
            var slowPointer = Head;
            var fastPointer = Head;
            while (fastPointer.Next != null && fastPointer.Next.Next != null)
            {
                fastPointer = fastPointer.Next.Next;
                slowPointer = slowPointer.Next;
            }
            Console.WriteLine($"The middle node has value{slowPointer.Value}");
        }
    }
}
