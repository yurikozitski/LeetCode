namespace LeetCode
{
    partial class Solution
    {
        public int[] FindMode(TreeNode root)
        {
            var result = new List<int>();
            var nodeCountTable = new Dictionary<int, int>();
            var nodeQueue = new Queue<TreeNode>();
            nodeQueue.Enqueue(root);

            while (nodeQueue.Count != 0)
            {
                var currentNode = nodeQueue.Dequeue();

                if (nodeCountTable.ContainsKey(currentNode.val))
                {
                    nodeCountTable[currentNode.val]++;
                }
                else
                {
                    nodeCountTable[currentNode.val] = 1;
                }

                if (currentNode.left != null)
                {
                    nodeQueue.Enqueue(currentNode.left);
                }

                if (currentNode.right != null)
                {
                    nodeQueue.Enqueue(currentNode.right);
                }
            }

            int maxCount = nodeCountTable.Values.Max();

            result.AddRange(
                nodeCountTable.Where(x => x.Value == maxCount).Select(x => x.Key));

            return result.ToArray();
        }
    }
}
