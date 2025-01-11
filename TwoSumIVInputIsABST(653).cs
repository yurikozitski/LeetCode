namespace LeetCode
{
    partial class Solution
    {
        public bool FindTarget(TreeNode root, int k)
        {
            var nodeTable = new HashSet<int>();

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

                nodeTable.Add(node.val);
            }

            Traverse(root);

            foreach (var nodeValue in nodeTable)
            {
                int m = k - nodeValue;

                if (nodeTable.TryGetValue(m, out int _) && m != nodeValue)
                {
                    return true;
                }
            }

            return false;
        }
    }

    static class DataForFindTarget
    {
        public static TreeNode GetTreeNode1()
        {
            TreeNode root = new TreeNode(0); 
            root.left = new TreeNode(-2);
            root.right = new TreeNode(3); 
            root.left.right = new TreeNode(-1);
            root.right.right = new TreeNode(4);

            return root;
        }
    }
}

