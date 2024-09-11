using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Leetcode.Solutions.BinaryTree;

namespace Leetcode.Solutions
{
    internal class Recursion
    {

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if(list1 == null)
            {
                return list2;
            }
            if(list2 == null)
            {
                return list1;
            }
            ListNode small, large;
            if(list1.val <= list2.val)
            {
                small = list1;
                large = list2; 
            }
            else
            {
                small = list2;
                large = list1;
            }
            small.next = MergeTwoLists(small.next, large);
            return small;
        }
        public ListNode MergeTwoLists1(ListNode list1, ListNode list2)
        {
            ListNode head = list1.val < list2.val ? list1 : list2;
            Merge(head, list1, list2);
            return head;
        }
        public ListNode Merge (ListNode head,ListNode list1, ListNode list2)
        {
            if(list1 == null)
            {
                head.next = list2;
                return head;
            }
            if(list1.val < list2.val)
            {
                head.next = list1;
                list1 = list1.next;
                return Merge(head.next, list1, list2);
            }
            else if(list1.val > list2.val)
            {
                head.next = list2;
                list2 = list2.next;
                return Merge(head.next, list1, list2);
            }
            else
            {
                head.next = list1;
                list1 = list1.next;
                head.next.next = list2;
                list2 = list2.next;
                return Merge(head.next.next, list1, list2);
            }
        }

        public double MyPow(double x, int n)
        {
            long N = n;
            if (n == 0)
                return 1;
            if(n<0)
            {
                x = 1 / x;
            }
            return CalPow(x, n);
        }
        public double CalPow(double x, long n)
        {
            if (n == 1)
                return x;
            double half = CalPow(x, n/2);
            return n % 2 == 0 ? half * half : half * half * x;
        }

        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            int left = MaxDepth(root.left);
            int right = MaxDepth(root.right);
            return Math.Max(left, right) + 1;
        }

        public int ClimbStairs(int n)
        {
            int[] dyp = new int[n+1];
            Array.Fill(dyp, -1);
            // base cases : 1-1, 2-2
            dyp[0] = 0;
            if(n>=1)
            dyp[1] = 1;
            if(n>=2)
            dyp[2] = 2;
            return GetValStairs(dyp, n);
        }

        public int GetValStairs(int[] dyp, int index)
        {
            if (dyp[index] != -1 || index < 3)
            {
                return dyp[index];
            }
            dyp[index] = GetValStairs(dyp,index - 1) + 1 + GetValStairs(dyp, index - 2) + 2;
            return dyp[index];
        }
        public int Fib(int n)
        {
            int[] dyp = new int[n+1];
            Array.Fill(dyp, -1);
            dyp[0] = 0;
            if(n>=1)
            dyp[1] = 1;
            return GetFibVal(dyp, n);
        }
        public int GetFibVal(int[] dyp, int index)
        {
            if (dyp[index] != -1)
                return dyp[index];
            dyp[index] = GetFibVal(dyp, index - 1) + GetFibVal(dyp, index - 2);
            return dyp[index];
        }

        public IList<int> GetRow(int rowIndex)
        {
            IList<int> result = new List<int>(new int[] { 1 });
            return GetValue(result, rowIndex);
        }
        public IList<int> GetValue(IList<int> prev, int rowIndex)
        {
            if(prev.Count == rowIndex+1)
            {
                return prev;
            }
            IList<int> result = new List<int>();
            int index = 1;
            result.Add(1);
            while (index <= prev.Count)
            {
                result.Add(prev[index - 1] + prev[index]);
                index++;
            }
            result.Add(1);
            result = GetValue(result, rowIndex);
            return result;
        }

        public int GetValue(int row, int col)
        {
            if (row == 0 || col == 0 || col == row)
            {
                return 1;
            }
            return GetValue(row - 1, col - 1) + GetValue(row - 1, col);
        }

        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null)
            {
                return null;
            }

            if (root.val == val)
            {
                return root;
            }
            TreeNode l = SearchBST(root.left, val), r = SearchBST(root.right, val);
            return l ?? r;
        }

        // Definition for singly-linked list.
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
        public ListNode ReverseList(ListNode head)
        {
            ListNode curr = head;
            ListNode prev = null;
            return recursiveHelper(curr, prev);
        }
        public ListNode recursiveHelper(ListNode curr, ListNode prev)
        {
            if (curr == null)
            {
                return prev;
            }
            var tempNext = curr.next;
            curr.next = prev;
            prev = curr;
            curr = tempNext;
            return recursiveHelper(curr, prev);
        }

        public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            var temp = head.next;   // 1234
            head.next = temp.next;  // 134
            temp.next = head;       // 2134
            head = temp;
            head.next.next = SwapPairs(head.next.next);
            return head;
        }

        public void printReverse(int index, string str)
        {
            if (str.Length > index)
            {
                printReverse(index + 1, str);
                Console.WriteLine(str[index]);
            }
            else
                return;
        }

        public void reverseStringInPlace(char[] s)
        {
            int left = 0, right = s.Length - 1;
            helper(s, left, right);
            Console.WriteLine(new string(s));
        }
        public void helper(char[] s, int left, int right)
        {
            if (left < right)
            {
                char temp = s[left];
                s[left] = s[right];
                s[right] = temp;
                helper(s, left + 1, right - 1);
            }
            else
            {
                return;
            }
        }
    }
}
