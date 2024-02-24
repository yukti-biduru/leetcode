using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    internal class DeleteMiddleNodeOfALinkedList
    {
        public ListNode DeleteMiddle(ListNode head)
        {
            return null;
        }
        public ListNode push(int new_data, ListNode preNode)
        {
            ListNode new_node = new ListNode(new_data);
            preNode.next = new_node;
            return new_node;
        }
    }
}
