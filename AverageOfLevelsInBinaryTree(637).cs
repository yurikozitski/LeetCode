namespace LeetCode
{
    partial class Solution
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            int level = 0;
            var resultTable = new Dictionary<int, (int Number, long Sum)>();

            void Traverse(TreeNode node)
            {
                if (resultTable.ContainsKey(level))
                {
                    var numberSumPair = resultTable[level];
                    numberSumPair = (numberSumPair.Number += 1, numberSumPair.Sum += node.val);
                    resultTable[level] = numberSumPair;
                }
                else
                {
                    resultTable[level] = (1, node.val);
                }

                if (node.left != null)
                {
                    level++;
                    Traverse(node.left);
                }

                if (node.right != null)
                {
                    level++;
                    Traverse(node.right);
                }

                level--;
            }

            Traverse(root);

            var result = new List<double>();

            for (int i = 0; i < resultTable.Count; i++)
            {
                result.Add(Math.Round((double)resultTable[i].Sum / resultTable[i].Number, 5));
            }

            return result;
        }
    }
}
