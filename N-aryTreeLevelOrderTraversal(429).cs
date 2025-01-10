using System.Xml.Linq;

namespace LeetCode
{
    partial class Solution
    {
        public IList<IList<int>> LevelOrder(Node root)
        {
            var result = new List<IList<int>>();

            if (root == null)
            {
                return result;
            }

            var nodeQueue = new Queue<(int Level, Node Node)>();
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

                if (currentNode.children != null)
                {
                    foreach (var childNode in currentNode.children)
                    {                        
                        nodeQueue.Enqueue((level + 1, childNode));
                    }
                }
            }

            return result;
        }
    }
}
