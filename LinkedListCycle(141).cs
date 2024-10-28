namespace LeetCode
{
    partial class Solution
    {
        public bool HasCycle(ListNode head)
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
                    return true;
                }
            }

            return false;
        }
    }
}
