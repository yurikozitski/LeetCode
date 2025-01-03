namespace LeetCode
{
    partial class Solution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode? currentA = headA;
            ListNode? currentB = headB;
            int lengthA = 1;
            int lengthB = 1;

            while (currentA != null || currentB != null)
            {
                if (currentA?.next != null)
                {
                    lengthA++;
                }

                if (currentB?.next != null)
                {
                    lengthB++;
                }

                currentA = currentA?.next;
                currentB = currentB?.next;
            }

            int skip = lengthA - lengthB;
            currentA = headA;
            currentB = headB;
            ListNode? res = null;

            while (currentA != null || currentB != null)
            {
                if (skip > 0)
                {
                    currentA = currentA?.next;
                    skip--;
                }
                else if (skip < 0)
                {
                    currentB = currentB?.next;
                    skip++;
                }
                else if (skip == 0)
                {
                    if (currentA == currentB)
                    {
                        res = currentA;
                        break;
                    }
                    else
                    {
                        currentA = currentA?.next;
                        currentB = currentB?.next;
                    }
                }
            }

            return res;
        }
    }
}
