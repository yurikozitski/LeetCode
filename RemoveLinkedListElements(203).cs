namespace LeetCode
{
    partial class Solution
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
            {
                return null!;
            }

            while (head?.val == val)
            {
                head = head.next;
            }

            ListNode previous = head!;
            ListNode current = head?.next!;

            while (current != null)
            {
                if (current.val == val)
                {
                    previous!.next = current.next;
                }
                else
                {
                    previous = current;
                }

                current = current.next;                
            }

            return head!;
        }
    }

    static class DataForRemoveElements
    {
        public static ListNode GetNodes1()
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(6);
            head.next.next.next = new ListNode(6);
            head.next.next.next.next = new ListNode(4);
            head.next.next.next.next.next = new ListNode(5);
            head.next.next.next.next.next.next = new ListNode(6);

            return head;
        }

        public static ListNode GetNodes2()
        {
            ListNode head = new ListNode(7);
            head.next = new ListNode(7);
            head.next.next = new ListNode(7);
            head.next.next.next = new ListNode(7);

            return head;
        }
    }
}
