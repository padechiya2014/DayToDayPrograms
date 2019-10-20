using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class DeleteDuplicateDistinct
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode current = head;
            ListNode prev = head;
            bool flag = false;


            while (current != null && current.next != null)
            {

                if (current.val == current.next.val)
                {

                    flag = true;
                    current.next = current.next.next;

                }
                else if (flag == true)
                {
                    if (prev == head)
                    {
                        head = head.next;
                    }
                    current = prev;
                    current.next = current.next.next;
                    flag = false;
                }

                else
                {
                    prev = current;
                    current = current.next;
                }
            }

            return head;
        }
    }
}
