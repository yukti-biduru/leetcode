using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{

    public class LinkedList
    {
        //public int PairSum1(ListNode head)
        //{
        //    List<int> lol = new List<int>();
        //    while(head != null)
        //    {
        //        lol.Add(head.val);
        //        head = head.next;
        //    }
        //}
        public int PairSum(ListNode head)
        {
            // reverse nodes until middle node is reached 
            ListNode reverseNode = new ListNode();
            ListNode prev = new ListNode();
            prev.next = head;
            ListNode fast = head;
            ListNode slow = prev;
            while(head != null && fast != null && fast.next != null)
            {
                reverseNode = new ListNode(head.val, reverseNode);
                slow = slow.next;
                fast = fast.next.next;
                head = head.next;
            }
            // add vals from reverese head to end
            int max = 0, sum=0;
            while(reverseNode != null && head != null)
            {
                sum = reverseNode.val + head.val;
                if( sum > max) max = sum;
                reverseNode = reverseNode.next;
                head = head.next;
            }
            return max;
        }
        public ListNode OddEvenList(ListNode head)
        {
            ListNode odd = new ListNode();
            ListNode oddhead = odd;
            ListNode even = new ListNode();
            ListNode evenhead = even;
            while (head != null && head.next != null)
            {
                odd.next = new ListNode(head.val);
                odd = odd.next;
                head = head.next;
                even.next = new ListNode(head.val);
                even = even.next;
                head = head.next;
            }
            if(head != null)
            {
                odd.next = new ListNode(head.val);
                odd = odd.next;
            }
            odd.next = evenhead.next;
            return oddhead.next;
        }
        public ListNode DeleteMiddle(ListNode head)
        {
            if (head == null || head.next == null)
                return null;
            ListNode prev = new ListNode(0);
            prev.next = head;
            ListNode fast = head;
            ListNode slow = prev;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }
        public ListNode ReverseList(ListNode head)
        {
            ListNode resultNode = null;
            while (head != null)
            {
                resultNode = new ListNode(head.val, resultNode);
                head = head.next;
            }
            return resultNode;
        }
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode front = head;
            ListNode back = head;
            for (int i = 1; i < n; i++)
            {
                if (front == null)
                {
                    return null;
                }
                front = front.next;
            }
            while (front != null)
            {
                front = front.next;
                back = back.next;
            }
            back.next = back.next.next;
            return head;
        }
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            HashSet<ListNode> nodes = new HashSet<ListNode>();
            while (headA != null || headB != null)
            {
                if (headA != null)
                {
                    if (nodes.Contains(headA))
                    {
                        return headA;
                    }
                    else
                    {
                        nodes.Add(headA);
                        headA = headA.next;
                    }
                }
                if (headB != null)
                {
                    if (nodes.Contains(headB))
                    {
                        return headB;
                    }
                    else
                    {
                        nodes.Add(headB);
                        headB = headB.next;
                    }
                }
            }
            return null;
        }
        public ListNode DetectCycle(ListNode head)
        {
            HashSet<ListNode> nodes = new HashSet<ListNode>();
            while (head != null)
            {
                if (nodes.Contains(head))
                {
                    return head;
                }
                else
                {
                    nodes.Add(head);
                }
                head = head.next;
            }
            return null;
        }
        public bool HasCycle(ListNode head)
        {
            if (head == null)
                return false;
            ListNode slow = head;
            ListNode fast = head.next;
            while (fast != null && slow != null)
            {
                if (fast == slow)
                {
                    return true;
                }
                slow = slow.next;
                fast = fast.next?.next;
            }
            return false;
        }

        private Node head;
        int count = 0;
        public class Node
        {
            public int val;
            public Node next;
            public Node(int n)
            {
                val = n;
            }
        }

        public int Get(int index)
        {
            Node node = GetNode(index);
            return node == null ? -1 : node.val;
        }

        public Node GetNode(int index)
        {
            if (index >= count)
            {
                return null;
            }
            Node curr = head;
            for (int i = 0; i < index; i++)
            {
                curr = curr.next;
            }
            return curr;
        }

        public void AddAtHead(int val)
        {
            Node node = new Node(val);
            node.next = head;
            head = node;
            count++;
        }

        public void AddAtTail(int val)
        {
            if (count == 0)
            {
                AddAtHead(val);
                return;
            }
            Node node = GetNode(count - 1);
            node.next = new Node(val);
            count++;
        }

        public void AddAtIndex(int index, int val)
        {
            if (index > count)
            {
                return;
            }
            if (index == 0)
            {
                AddAtHead(val);
                return;
            }
            Node node = GetNode(index - 1);
            Node newNode = new Node(val);
            newNode.next = node.next;
            node.next = newNode;
            count++;
        }

        public void DeleteAtIndex(int index)
        {
            if (count == 0)
            {
                return;
            }
            if (index < count && index >= 0)
            {
                if (index == 0)
                {
                    head = head.next;
                }
                else
                {
                    var node = GetNode(index - 1);
                    node.next = node.next.next;
                }
                count--;
            }
        }
    }
}