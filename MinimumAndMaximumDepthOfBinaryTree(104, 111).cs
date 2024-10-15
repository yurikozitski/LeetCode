namespace LeetCode
{
    partial class Solution
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var nodeQueue = new Queue<(int Depth, TreeNode Node)>();
            nodeQueue.Enqueue((1, root));

            while (true)
            {
                var currentNodeTuple = nodeQueue.Dequeue();
                var currentNode = currentNodeTuple.Node;

                if (currentNode.left == null && currentNode.right == null)
                {
                    return currentNodeTuple.Depth;
                }

                if (currentNode.left != null)
                {
                    nodeQueue.Enqueue((currentNodeTuple.Depth + 1, currentNode.left));
                }

                if (currentNode.right != null)
                {
                    nodeQueue.Enqueue((currentNodeTuple.Depth + 1, currentNode.right));
                }
            }
        }

        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var nodeQueue = new Queue<(int Depth, TreeNode Node)>();
            nodeQueue.Enqueue((1, root));

            while (true)
            {
                var currentNodeTuple = nodeQueue.Dequeue();
                var currentNode = currentNodeTuple.Node;

                if (currentNode.left != null)
                {
                    nodeQueue.Enqueue((currentNodeTuple.Depth + 1, currentNode.left));
                }

                if (currentNode.right != null)
                {
                    nodeQueue.Enqueue((currentNodeTuple.Depth + 1, currentNode.right));
                }

                if (nodeQueue.Count == 0)
                {
                    return currentNodeTuple.Depth;
                }
            }
        }
    }
}
