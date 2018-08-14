using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class RotateList
    {
        Node head; // head of linked list

        public Node Head { get => head; set => head = value; }

        public class Node
        {
            int data;
            private Node next;
            public Node(int d)
            {
                Data = d;
                Next = null;
            }

            public Node Next { get => next; set => next = value; }
            public int Data { get => data; set => data = value; }
        }

        /* Inserts a new Node at front of the list. */
        public void push(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.Next = Head;
            Head = new_node;
        }

        /* This function prints contents of linked list starting from
            the given node */
        public void printList()
        {
            Node tnode = Head;
            while (tnode != null)
            {
                Console.WriteLine(tnode.Data + " ");
                Console.ReadLine();
                tnode = tnode.Next;
            }
        }


        public void RotateLinkedList(int k)
        {
            Node temp = head;
            Node prev = null;
            int counter = 1;
            Node kthNode = null;
            Node KplusOneNode = null;
            Node oldHead = head;

            while(temp !=null && counter != k)
            {
                prev = temp;
                temp = temp.Next;
                counter++;
            }
            kthNode = temp;
           
            KplusOneNode = temp.Next;
            Head = KplusOneNode;
            temp.Next = null;
            while (KplusOneNode.Next != null)
            {
                prev = KplusOneNode;
                KplusOneNode = KplusOneNode.Next;
            }

            KplusOneNode.Next = oldHead;


        }

        public void ReverseAndRotateList(int k)
        {
            Node temp = head;
            Node prev = null;
            int counter = 1;
            Node kthNode = null;
            Node KplusOneNode = null;
            Node oldHead = head;
            Stack<Node> st1 = new Stack<Node>();
            Stack<Node> st2 = new Stack<Node>();

            while (temp != null && counter != k)
            {
                // Fill stack
                st1.Push(temp);
                prev = temp;
                temp = temp.Next;
                counter++;
            }
            // Fill stack with kth item
            kthNode = temp;
            st1.Push(kthNode);

            KplusOneNode = temp.Next;
            Head = KplusOneNode;
            temp.Next = null;
            while (KplusOneNode.Next != null)
            {
                // Fill stack with remaining items
                st1.Push(KplusOneNode);
                prev = KplusOneNode;
                KplusOneNode = KplusOneNode.Next;
            }

            st1.Push(KplusOneNode);
            KplusOneNode.Next = oldHead;
            

            foreach (var item in st1)
            {
                Console.WriteLine(item.Data + "\n");
                
            }
            Console.ReadLine();
        }
    }
}
