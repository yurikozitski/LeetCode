namespace LeetCode
{
    partial class Solution
    {
        public ListNode? MergeTwoLists(ListNode list1, ListNode list2)
        {
            var head = new List<ListNode>();

            while (list1 != null)
            {
                head.Add(list1);
                list1 = list1.next;
            }

            while (list2 != null)
            {
                head.Add(list2);
                list2 = list2.next;
            }

            head.Sort((node1, node2) =>
            {
                if (node1.val < node2.val) return -1;
                if (node1.val > node2.val) return 1;
                return 0;
            });

            if (head.Count > 0)
            {
                head[head.Count - 1].next = null!;
            }

            for (int i = 0; i < head.Count - 1; i++)
            {
                head[i].next = head[i + 1];
            }

            ListNode? headNode = head.Count > 0 ? head[0] : null;

            return headNode;
        }
    }
}
