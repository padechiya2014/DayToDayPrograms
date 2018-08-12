using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class DeleteLastOccurence
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
            Node new_node = new Node(new_data);
            new_node.Next = head;
            head = new_node;
        }

        /* This function prints contents of linked list starting from
            the given node */
        public void printList()
        {
            Node tnode = head;
            while (tnode != null)
            {
                Console.WriteLine(tnode.Data + " ");
                Console.ReadLine();
                tnode = tnode.Next;
            }
        }

        /* Given a key, deletes the first occurrence of key in linked list */
        public void deleteLastOccuringNode(int key)
        {
            // Store head node
            Node temp = head, prev = null;
            Node nodeTobeDeleted = null;
            Node temp2 = null;

            
            // Search for the key to be deleted, keep track of the
            // previous node as we need to change temp.next
            while (temp != null)
            {
                if (temp.Data != key)
                {
                    prev = temp;
                    temp = temp.Next;
                }
                else
                {
                    nodeTobeDeleted = temp;
                    temp2 = prev;
                    prev = temp;
                    temp = temp.Next;
                }
            }

            
            // Unlink the node from linked list
            if(nodeTobeDeleted != null)
            {
                temp2.Next = nodeTobeDeleted.Next;
            }
           
        }
    }
}
