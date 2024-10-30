using System.Xml.Linq;

namespace LeetCode
{
    partial class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
            {
                return null!;
            }

            ListNode p = head, n = null!;

            while (p != null)
            {
                ListNode tmp = p.next;
                p.next = n;
                n = p;
                p = tmp;
            }

            head = n;

            return head;
        }

        public ListNode ReverseListWithStack(ListNode head)
        {
            if (head == null)
            {
                return null!;
            }

            var nodeStack = new Stack<ListNode>();

            while (head != null)
            { 
                nodeStack.Push(head);
                head = head.next;
            }

            ListNode reversed = nodeStack.Pop();
            ListNode current = reversed;

            while (nodeStack.Count > 0)
            {
                current.next = nodeStack.Pop();

                if (nodeStack.Count == 0)
                {
                    current.next.next = null!;
                }

                current = current.next;
            }

            return reversed;
        }
    }

    static class DataForReverseList
    {
        public static ListNode GetHead()
        {
            var head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);

            return head;
        }
    }
}
