using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class DeleteNodesMoreThanKcs
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
        public void deleteNode(int key)
        {
            // Store head node
            Node temp = head, prev = null;

            // If head node itself holds the key to be deleted
            if (temp != null && temp.Data == key)
            {
                head = temp.Next; // Changed head
                return;
            }

            // Search for the key to be deleted, keep track of the
            // previous node as we need to change temp.next
            while (temp != null && temp.Data != key)
            {
                prev = temp;
                temp = temp.Next;
            }

            // If key was not present in linked list
            if (temp == null) return;

            // Unlink the node from linked list
            prev.Next = temp.Next;
        }

        
        public void deleteAllNodesGreaterThanKey(int key)
        {
            // Store head node
            Node temp = head;
            Node prev = null;

            // Head node value greater than key
            while (temp != null && temp.Data > key)
            {
                head = temp.Next; // Changed head
                temp = head;
            }


            while (temp != null)
            {
                if(temp.Data <= key)
                {
                    prev = temp;
                    temp = temp.Next;
                }
                else
                {
                    // Unlink the node from linked list
                    prev.Next = temp.Next;
                    temp = temp.Next; // temp = prev.Next(this will also work);
                }
               
            }

            // return head in case return type is  Node or SinglyLinkedList(HackerRank)

        }
    }
}
