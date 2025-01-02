namespace LeetCode
{
    partial class Solution
    {
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            bool isSubtree = false;

            TraverseTree(root);

            void TraverseTree(TreeNode root)
            {
                if (root.val == subRoot.val && !isSubtree)
                {
                    isSubtree = IsSameTree(root, subRoot);
                }

                if (root.left != null)
                {
                    TraverseTree(root.left);
                }

                if (root.right != null)
                {
                    TraverseTree(root.right);
                }
            }

            bool IsSameTree(TreeNode p, TreeNode q)
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

            return isSubtree;
        }        
    }

    public static class DataForIsSubtree
    {
        public static TreeNode DataForIsSubtree_1()
        {
            List<int?> values = new List<int?> { -24, -25, -25, -24, -24, -26, -24, -23, -23, null, null, -27, -25, -23, -23, -22, -24, -22, -22, -26, -26, -26, -26, -22, -22, -24, -24, null, null, -23, -25, -21, -21, null, -21, -27, -25, -25, -27, -25, null, -25, -27, -23, -21, -23, -23, null, -23, -25, -23, null, null, null, null, null, -22, -20, -20, null, null, null, null, null, -26, -26, -24, -28, -28, null, null, null, -26, -28, null, null, -22, -22, -20, -22, -24, -24, null, -22, -24, -24, null, -22, null, null, -23, null, null, -19, -21, null, null, -27, -25, -25, -25, null, -27, -27, null, null, null, -29, null, -21, -23, null, null, -19, -19, -21, -21, -23, -25, null, null, null, -21, null, null, null, null, null, null, null, null, -18, -18, null, -20, null, null, null, -26, -26, -24, null, -24, -28, null, -28, -26, null, -30, -20, null, -22, null, -20, -20, -20, -18, null, -20, null, -20, null, -24, -24, null, null, null, null, null, -17, -17, null, null, null, null, -25, -25, -25, null, null, null, -29, null, -29, null, null, null, null, null, null, null, -21, null, -21, null, -19, -19, -21, null, null, -17, -19, -21, -21, null, null, -23, null, null, null, -16, null, null, -24, -24, null, null, -24, -24, null, null, null, null, null, -22, null, -20, null, null, null, null, -22, -22, -18, -16, null, null, null, null, -22, -20, null, null, null, null, -25, -23, null, null, -25, null, null, null, -23, null, null, null, null, -23, -21, -21, -19, null, -17, -15, null, -21, null, -19, null, null, null, null, null, null, null, -24, -24, -22, null, -20 };

            if (values == null || values.Count == 0) return null;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            TreeNode root = new TreeNode((int)values[0]);
            queue.Enqueue(root);
            int i = 1;
            while (i < values.Count)
            {
                TreeNode current = queue.Dequeue();
                if (values[i] != null)
                {
                    current.left = new TreeNode((int)values[i]);
                    queue.Enqueue(current.left);
                }
                i++;
                if (i < values.Count && values[i] != null)
                {
                    current.right = new TreeNode((int)values[i]);
                    queue.Enqueue(current.right);
                }
                i++;
            }
            return root;
        }

        public static TreeNode DataForIsSubtree_2()
        {
            List<int?> values = new List<int?> { -17, null, -16 };

            if (values == null || values.Count == 0) return null;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            TreeNode root = new TreeNode((int)values[0]);
            queue.Enqueue(root);
            int i = 1;
            while (i < values.Count)
            {
                TreeNode current = queue.Dequeue();
                if (values[i] != null)
                {
                    current.left = new TreeNode((int)values[i]);
                    queue.Enqueue(current.left);
                }
                i++;
                if (i < values.Count && values[i] != null)
                {
                    current.right = new TreeNode((int)values[i]);
                    queue.Enqueue(current.right);
                }
                i++;
            }
            return root;
        }
    }
}
