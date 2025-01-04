namespace LeetCode
{
    partial class Solution
    {
        public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            if (root1 != null && root2 != null)
            {
                root1.val += root2.val;

                if (root1.left == null)
                {
                    root1.left = root2.left;
                    root2.left = null;
                }

                if (root1.right == null)
                {
                    root1.right = root2.right;
                    root2.right = null;
                }
            }
            else if (root1 == null && root2 != null)
            {
                root1 = root2;
            }

            if (root1?.left != null)
            {
                MergeTrees(root1.left, root2?.left);
            }

            if (root1?.right != null)
            {
                MergeTrees(root1.right, root2?.right);
            }

            return root1;
        }
    }
}
