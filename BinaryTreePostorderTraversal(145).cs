namespace LeetCode
{
    partial class Solution
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            var result = new List<int>();

            if (root == null)
            {
                return result;
            }

            Traverse(root);

            void Traverse(TreeNode node)
            {
                if (node.left != null)
                {
                    Traverse(node.left);
                }

                if (node.right != null)
                {
                    Traverse(node.right);
                }

                result.Add(node.val);
            }

            return result;
        }
    }
}
