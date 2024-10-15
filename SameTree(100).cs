namespace LeetCode
{
    partial class Solution
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }
            else if (p == null || q == null)
            {
                return false;
            }

            var nodeQueueP = new Queue<TreeNode>();
            var nodeQueueQ = new Queue<TreeNode>();

            nodeQueueP.Enqueue(p);
            nodeQueueQ.Enqueue(q);

            while (true)
            {
                var currentNodeP = nodeQueueP.Dequeue();
                var currentNodeQ = nodeQueueQ.Dequeue();

                if (currentNodeP.val != currentNodeQ.val)
                {
                    return false;
                }

                if (currentNodeP.left != null && currentNodeQ.left != null)
                {
                    nodeQueueP.Enqueue(currentNodeP.left);
                    nodeQueueQ.Enqueue(currentNodeQ.left);
                }
                else if ((currentNodeP.left == null && currentNodeQ.left != null) ||
                    (currentNodeP.left != null && currentNodeQ.left == null))
                {
                    return false;
                }

                if (currentNodeP.right != null && currentNodeQ.right != null)
                {
                    nodeQueueP.Enqueue(currentNodeP.right);
                    nodeQueueQ.Enqueue(currentNodeQ.right);
                }
                else if ((currentNodeP.right == null && currentNodeQ.right != null) ||
                    (currentNodeP.right != null && currentNodeQ.right == null))
                {
                    return false;
                }

                if (nodeQueueP.Count == 0 && nodeQueueQ.Count == 0)
                {
                    return true;
                }
            }
        }
    }
}
