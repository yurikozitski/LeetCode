namespace LeetCode
{
    partial class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return default!;
            }

            if (root.left != null && root.right != null)
            {
                (root.left, root.right) = (root.right, root.left);
                InvertTree(root.left);
                InvertTree(root.right);
                return root;
            }

            if (root.left != null)
            {
                root.right = root.left;
                root.left = null!;
                InvertTree(root.right);
                return root;
            }

            if (root.right != null)
            {
                root.left = root.right;
                root.right = null!;
                InvertTree(root.left);
                return root;
            }

            return root;
        }
    }

    static class TestDataForInvertBinaryTree
    {
        public static TreeNode GetRoot1()
        {
            TreeNode root = new TreeNode(4);

            root.left = new TreeNode(2);
            root.right = new TreeNode(7);

            root.left.left = new TreeNode(1);
            root.left.right = new TreeNode(3);

            root.right.left = new TreeNode(6);
            root.right.right = new TreeNode(9);

            return root;
        }

        public static TreeNode GetRoot2()
        {
            TreeNode root2 = new TreeNode(1);
            root2.left = new TreeNode(2);

            return root2;
        }

        //public TreeNode GetRoot3()
        //{
        //    TreeNode root3 = new TreeNode(3);
        //    root3.left = new TreeNode(1);
        //    root3.left.right = new TreeNode(2);

        //    return root3;
        //}
    }
}
