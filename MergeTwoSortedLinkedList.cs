using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class ListNode
    {
      public int val;
      public ListNode next;
     public ListNode(int x) { val = x; }
  }

    public class Solution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {

            ListNode list1 = l1;
            ListNode list2 = l2;

            if (list1 == null && list2 == null)
            {
                return list1;
            }
            List<ListNode> arrList = new List<ListNode>();

            while (list1 != null)
            {
                arrList.Add(list1);
                list1 = list1.next;
            }

            while (list2 != null)
            {
                arrList.Add(list2);
                list2 = list2.next;
            }

            List<ListNode> SortedList = arrList.OrderBy(o => o.val).ToList();
            ListNode head = new ListNode(SortedList[0].val);
            ListNode temp = head;
            for (int i = 1; i < SortedList.Capacity; i++)
            {
                ListNode newNode = new ListNode(SortedList[i].val);
                temp.next = newNode;
                temp = newNode;

            }

            return head;
        }
    }
}
