namespace LeetCode
{
    partial class Solution
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            var result = new List<int>();

            if (root == null)
            {
                return result;
            }

            Traverse(root);

            void Traverse(TreeNode node)
            {
                result.Add(node.val);

                if (node.left != null)
                {
                    Traverse(node.left);
                }

                if (node.right != null)
                {
                    Traverse(node.right);
                }
            }

            return result;
        }
    }
}
