namespace LeetCode
{
    partial class Solution
    {
        public ListNode DetectCycle(ListNode head)
        {
            var listSet = new HashSet<ListNode>();
            ListNode current = head;

            while (current != null)
            {
                if (listSet.Add(current))
                {
                    current = current.next;
                }
                else
                {
                    return current;
                }
            }

            return null!;
        }
    }
}
