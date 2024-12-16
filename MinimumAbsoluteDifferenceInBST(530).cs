namespace LeetCode
{
    partial class Solution
    {
        public int GetMinimumDifference(TreeNode root)
        {
            var nodeValuesList = new List<int>();

            var nodeQueue = new Queue<TreeNode>();
            nodeQueue.Enqueue(root);

            while (nodeQueue.Count != 0)
            {
                var currentNode = nodeQueue.Dequeue();

                nodeValuesList.Add(currentNode.val);
                
                if (currentNode.left != null)
                {
                    nodeQueue.Enqueue(currentNode.left);
                }

                if (currentNode.right != null)
                {
                    nodeQueue.Enqueue(currentNode.right);
                }
            }

            nodeValuesList.Sort();

            int result = Math.Abs(nodeValuesList[0] - nodeValuesList[1]);

            for (int i = 1; i < nodeValuesList.Count - 1; i++)
            {
                int currentDiff = Math.Abs(nodeValuesList[i] - nodeValuesList[i + 1]);

                if (currentDiff < result)
                {
                    result = currentDiff;
                }
            }

            return result;
        }
    }
}
