namespace LeetCode
{
    partial class Solution
    {
        public IList<int> Preorder(Node root)
        {
            var result = new List<int>();

            if (root == null)
            {
                return result;
            }

            Traverse(root);

            void Traverse(Node node)
            {
                result.Add(node.val);

                if (node.children != null)
                {
                    foreach (var childNode in node.children)
                    {
                        Traverse(childNode);
                    }
                }
            }

            return result;
        }
    }
}
