namespace LeetCode
{
    partial class Solution
    {
        //NOT WORKING
        public bool IsValidBST(TreeNode root)
        {
            if (root.left == null && root.right == null)
            {
                return true;
            }

            var nodeStack = new Stack<TreeNode>();
            var current = root;
            nodeStack.Push(current);
            int rootVal = root.val;
            bool isInLeftBranch = true;

            while (nodeStack.Count != 0)
            {
                if (current.left != null)
                {
                    if (current.left.val >= current.val)
                    {
                        return false;
                    }

                    current = current.left;
                    nodeStack.Push(current);
                }
                else
                {
                    var currentTemp = nodeStack.Pop().right;

                    if (currentTemp != null)
                    {
                        if (currentTemp.val <= current.val)
                        {
                            return false;
                        }

                        nodeStack.Push(currentTemp);
                        current = currentTemp;
                        continue;
                    }

                    while (true)
                    {
                        if (nodeStack.Count > 0)
                        {
                            current = nodeStack.Pop();
                        }
                        else
                        {
                            if (current.right == null)
                            {
                                break;
                            }
                        }

                        if (nodeStack.Count == 0)
                        {
                            isInLeftBranch = false;
                        }

                        if (current.right != null)
                        {
                            if (current.right.val <= current.val)
                            {
                                return false;
                            }

                            current = current.right;
                            nodeStack.Push(current);
                            break;
                        }
                    }
                }

                if (nodeStack.Count != 0)
                {
                    if (isInLeftBranch && current.val >= rootVal)
                    {
                        return false;
                    }

                    if (!isInLeftBranch && current.val <= rootVal)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }

    static class DataForIsValidBST
    {
        public static TreeNode GetTreeNode1()
        {
            TreeNode root = new TreeNode(2);
            root.left = new TreeNode(1);
            root.right = new TreeNode(3);

            return root;
        }

        public static TreeNode GetTreeNode2()
        {
            TreeNode root = new TreeNode(0);

            return root;
        }

        public static TreeNode GetTreeNode3()
        {
            TreeNode root = new TreeNode(0);
            root.left = new TreeNode(-1);

            return root;
        }
    }
}
