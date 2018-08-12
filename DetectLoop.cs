using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class DetectLoop
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

        public bool detectLoopUsingDictionary(Node h)
        {
            HashSet<Node> hs = new HashSet<Node>();
            while (h != null)
            {
                
                if (hs.Contains(h))
                    return true;

                // If we are seeing the node for
                // the first time, insert it in hash
                hs.Add(h);

                h = h.Next;
            }

            return false;
        }

        public bool detectLoopUsingSlowFastPointers(Node h)
        {
            Node slow_p = head;
            Node fast_p = head;
            while (slow_p != null && fast_p != null && fast_p.Next != null)
            {
                slow_p = slow_p.Next;
                fast_p = fast_p.Next.Next;
                if (slow_p == fast_p)
                {
                    return true;
                }
            }
            return false;
        }

        public void DetectAndRemoveLoop(Node h)
        {
            Node slow_p = head;
            Node fast_p = head;
            while (slow_p != null && fast_p != null && fast_p.Next != null)
            {
                slow_p = slow_p.Next;
                fast_p = fast_p.Next.Next;
                if (slow_p == fast_p)
                {
                    RemoveLoop(slow_p, h);
                }
            }
           
        }

        public void RemoveLoop(Node loop,Node curr)
        {
            Node ptr1 = null, ptr2 = null;

            /* Set a pointer to the beging of the Linked List and
             move it one by one to find the first node which is
             part of the Linked List */
            ptr1 = curr;
            while (1 == 1)
            {

                /* Now start a pointer from loop_node and check if it ever
                 reaches ptr2 */
                ptr2 = loop;
                while (ptr2.Next != loop && ptr2.Next != ptr1)
                {
                    ptr2 = ptr2.Next;
                }

                /* If ptr2 reahced ptr1 then there is a loop. So break the
                 loop */
                if (ptr2.Next == ptr1)
                {
                    break;
                }

                /* If ptr2 did't reach ptr1 then try the next node after ptr1 */
                ptr1 = ptr1.Next;
            }

            /* After the end of loop ptr2 is the last node of the loop. So
             make next of ptr2 as NULL */
            ptr2.Next = null;
        }
    }
}
