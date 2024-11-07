namespace LeetCode
{
    partial class Solution
    {
        int sum = 0;
        bool isLeft = false;

        public int SumOfLeftLeaves(TreeNode root)
        {
            if (root.left != null)
            {
                isLeft = true;
                SumOfLeftLeaves(root.left);
            }

            if (root.left == null && root.right == null && isLeft)
            {
                sum += root.val;
            }

            if (root.right != null)
            {
                isLeft = false;
                SumOfLeftLeaves(root.right);
            }

            return sum;
        }
    }

    static class DataForSumOfLeftLeaves
    {
        public static TreeNode GetTreeNode1()
        {
            TreeNode root = new TreeNode(3); 
            root.left = new TreeNode(9); 
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15); 
            root.right.right = new TreeNode(7);

            return root;
        }
    }
}
