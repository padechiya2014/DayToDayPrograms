using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Case 1 - Find middle element
            FindMiddleElement llist = new FindMiddleElement();
            for (int i = 5; i > 0; --i)
            {
                llist.push(i);
                llist.printList();
                llist.printMiddle();
            }


            //// Case 2 - Delete the first occurence
            DeleteFirstOccurence dlList = new DeleteFirstOccurence();

            dlList.push(7);
            dlList.push(1);
            dlList.push(3);
            dlList.push(2);

            Console.WriteLine("\nCreated Linked list is:");
            Console.ReadLine();
            dlList.printList();

            dlList.deleteNode(1); // Delete node at position 4

            Console.WriteLine("\nLinked List after Deletion at position 4:");
            Console.ReadLine();
            dlList.printList();


            // Case 3 - Delete all the occurences
            DeleteFirstOccurence dlListCase3 = new DeleteFirstOccurence();
            dlList.push(7);
            dlList.push(2);
            dlList.push(3);
            dlList.push(2);
            dlList.push(8);
            dlList.push(1);
            dlList.push(2);
            dlList.push(2);
            dlList.push(4);
            dlList.push(5);
            dlList.push(4);
            dlList.push(4);
            dlList.push(4);
            dlList.push(3);
            dlList.push(2);
            dlList.push(1);

            Console.WriteLine("\nCreated Linked list is:");
            Console.ReadLine();
            dlList.printList();

            dlList.deleteAllMatchingNodes(4); // Delete node at position 4

            Console.WriteLine("\nLinked List after Deletion at position 4:");
            Console.ReadLine();
            dlList.printList();


            // Case 4 - Delete the last element
            DeleteFirstOccurence dlListCase4 = new DeleteFirstOccurence();
            dlList.push(4);
            dlList.push(5);
            dlList.push(4);
            dlList.push(4);
            dlList.push(4);
            dlList.push(3);
            dlList.push(2);
            dlList.push(1);

            Console.WriteLine("\nCreated Linked list is:");
            Console.ReadLine();
            dlList.printList();

            dlList.DeleteLastElemnt(); // Delete node at position 4

            Console.WriteLine("\nLinked List after Deletion of last element:");
            Console.ReadLine();
            dlList.printList();

            // Case 5 - Print the reverse of a Linked List
            Reverse ReverseList = new Reverse();
            ReverseList.push(4);
            ReverseList.push(5);
            ReverseList.push(4);
            ReverseList.push(4);
            ReverseList.push(4);
            ReverseList.push(3);
            ReverseList.push(2);
            ReverseList.push(1);

            Console.WriteLine("\nCreated Linked list is:");
            Console.ReadLine();
            ReverseList.printList();

            ReverseList.printReverse();

            // Case 6 - Delete the Last occurence of the given key
            DeleteLastOccurence delLastOccList = new DeleteLastOccurence();
            delLastOccList.push(4);
            delLastOccList.push(4);
            delLastOccList.push(5);
            delLastOccList.push(4);
            delLastOccList.push(3);
            delLastOccList.push(2);
            delLastOccList.push(1);

            Console.WriteLine("\nCreated Linked list is:");
            Console.ReadLine();
            delLastOccList.printList();

            delLastOccList.deleteLastOccuringNode(4);

            Console.WriteLine("\nCreated Linked list is:");
            Console.ReadLine();
            delLastOccList.printList();

            // Case 7 - Detect a loop in a singly Linked List
            DetectLoop dtLoop = new DetectLoop();
            //dtLoop.push(10);
            dtLoop.push(20);
            dtLoop.push(4);
            dtLoop.push(15);
            dtLoop.push(10);

            // Create a loop
            dtLoop.Head.Next.Next.Next.Next = dtLoop.Head;

            if (dtLoop.detectLoopUsingDictionary(dtLoop.Head))
            {
                Console.WriteLine("Loop found");
                Console.ReadLine();
            }
            if (dtLoop.detectLoopUsingSlowFastPointers(dtLoop.Head))
            {
                Console.WriteLine("Loop found");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("No Loop");
                Console.ReadLine();
            }


            // Case 8 - Detect and Remove a loop
            dtLoop.DetectAndRemoveLoop(dtLoop.Head);

            // Case 9 - Rotate Linked List
            RotateList rotateList = new RotateList();
            rotateList.push(60);
            rotateList.push(50);
            rotateList.push(40);
            rotateList.push(30);
            rotateList.push(20);
            rotateList.push(10);


            Console.WriteLine("\nCreated Linked list is:");
            Console.ReadLine();
            rotateList.printList();

            rotateList.RotateLinkedList(4);

            Console.WriteLine("\nRotated Linked list is:");
            Console.ReadLine();
            rotateList.printList();

            // Case 10 - Rotate and reverse a linked list
            RotateList rotateListCase10 = new RotateList();
            rotateList.push(8);
            rotateList.push(7);
            rotateList.push(6);
            rotateList.push(5);
            rotateList.push(4);
            rotateList.push(3);
            rotateList.push(2);
            rotateList.push(1);
            Console.WriteLine("\nCreated Linked list is:");
            Console.ReadLine();
            rotateList.printList();

            rotateList.ReverseAndRotateList(3);

            Console.WriteLine("\nRotated Linked list is:");
            Console.ReadLine();
            rotateList.printList();
        }
    }
}
