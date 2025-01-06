namespace LeetCode
{
    partial class Solution
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();

            if (root == null)
            {
                return result;
            }

            var nodeQueue = new Queue<(int Level, TreeNode Node)>();
            nodeQueue.Enqueue((0, root));

            while (nodeQueue.Count != 0)
            {
                var currentNodeTuple = nodeQueue.Dequeue();
                int level = currentNodeTuple.Level;
                var currentNode = currentNodeTuple.Node;

                if (result.Count <= level)
                {
                    result.Add(new List<int>() { currentNode.val });
                }
                else
                {
                    result[level].Add(currentNode.val);
                }

                if (currentNode.left != null)
                {
                    nodeQueue.Enqueue((level + 1, currentNode.left));
                }

                if (currentNode.right != null)
                {
                    nodeQueue.Enqueue((level + 1, currentNode.right));
                }
            }

            return result;
        }
    }
}
