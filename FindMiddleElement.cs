using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class FindMiddleElement
    {
        Node head; // head of linked list
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
            /* 1 & 2: Allocate the Node &
                    Put in the data*/
            Node new_node = new Node(new_data)
            {

                /* 3. Make next of new Node as head */
                Next = head
            };

            /* 4. Move the head to point to new Node */
            head = new_node;
        }


        public void printMiddle()
        {
            Node slow_ptr = head;
            Node fast_ptr = head;
            if (head != null)
            {
                while (fast_ptr != null && fast_ptr.Next != null)
                {
                    fast_ptr = fast_ptr.Next.Next;
                    slow_ptr = slow_ptr.Next;
                }
                Console.WriteLine("The middle element is [" +
                                    slow_ptr.Data + "] \n");
                Console.ReadLine();

            }
        }

        /* This function prints contents of linked list
	starting from the given node */
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
    }
}
