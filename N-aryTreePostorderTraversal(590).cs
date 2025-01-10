namespace LeetCode
{
    partial class Solution
    {
        public IList<int> Postorder(Node root)
        {
            var result = new List<int>();

            if (root == null)
            {
                return result;
            }

            Traverse(root);

            void Traverse(Node node)
            {                
                if (node.children != null)
                {
                    foreach (var childNode in node.children)
                    {
                        Traverse(childNode);
                    }
                }

                result.Add(node.val);
            }

            return result;
        }
    }
}
