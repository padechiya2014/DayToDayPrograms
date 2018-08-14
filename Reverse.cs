using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Reverse
    {
        Node head;
        public class Node
        {
            private int data;
            private Node next;

            public Node(int d)
            {
                data = d;
                next = null;
            }

            public int Data { get => data; set => data = value; }
            public Node Next { get => next; set => next = value; }
        }

        public void push(int data)
        {
            Node new_node = new Node(data);
            new_node.Next = head;
            head = new_node;
        }

        public void printList()
        {
            Node tnode = head;
            while (tnode != null)
            {
                Console.WriteLine(tnode.Data + "->");
                Console.ReadLine();
                tnode = tnode.Next;
            }
            Console.WriteLine("NULL");
            Console.ReadLine();
        }

        public void printReverse()
        {
            Node temp = head;
         
            Stack<Node> reverse = new Stack<Node>();

            while(temp != null)
            {
                reverse.Push(temp);
                temp = temp.Next;
            }

           
               // Node tnode = head;
                while (reverse.Count > 0)
                {
                    Console.WriteLine(reverse.Pop().Data + "->");
                    Console.ReadLine();
                    //tnode = tnode.Next;
                }

            
        }
    }
}
