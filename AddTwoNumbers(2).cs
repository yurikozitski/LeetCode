using System;
using System.Text;

namespace LeetCode
{
    partial class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var l1Stack = new Stack<int>();
            var l2Stack = new Stack<int>();

            while (l1 != null)
            {
                l1Stack.Push(l1.val);
                l1 = l1.next;
            }

            while (l2 != null)
            {
                l2Stack.Push(l2.val);
                l2 = l2.next;
            }

            var n1Sb = new StringBuilder();
            var n2Sb = new StringBuilder();

            while (l1Stack.Count > 0)
            {
                n1Sb.Append(l1Stack.Pop());
            }

            while (l2Stack.Count > 0)
            {
                n2Sb.Append(l2Stack.Pop());
            }

            string res = this.AddStrings(n1Sb.ToString(), n2Sb.ToString());
            var resArr = res.ToCharArray().Reverse().ToArray();

            var resNode = new ListNode();
            var resHead = resNode;

            for (int i = 0; i < resArr.Length; i++)
            {
                resNode.val = Int32.Parse(resArr[i].ToString());

                if (i != resArr.Length - 1)
                {
                    resNode.next = new ListNode();
                    resNode = resNode.next;
                }
                else
                {
                    resNode.next = null!;
                }
            }

            return resHead;
        }
    }

    static class DataForAddTwoNumbers
    {
        public static ListNode GetNode1()
        {
            int[] values = { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 }; 
            ListNode head = new ListNode(values[0]); 
            ListNode current = head; 
            for (int i = 1; i < values.Length; i++) 
            { 
                current.next = new ListNode(values[i]); 
                current = current.next; 
            }

            return head;
        }

        public static ListNode GetNode2()
        {
            int[] values = { 5, 6, 4 };
            ListNode head = new ListNode(values[0]);
            ListNode current = head;
            for (int i = 1; i < values.Length; i++)
            {
                current.next = new ListNode(values[i]);
                current = current.next;
            }

            return head;
        }
    }
}
