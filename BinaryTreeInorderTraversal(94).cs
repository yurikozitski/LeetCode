namespace LeetCode
{
    partial class Solution
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return Enumerable.Empty<int>().ToList();
            }

            var rusultList = new List<int>();
            var nodeStack = new Stack<TreeNode>();
            TreeNode current = root;
            nodeStack.Push(current);

            while (true)
            {
                if (current.left != null)
                {
                    current = current.left;
                    nodeStack.Push(current);
                }
                else
                {
                    rusultList.Add(current.val);
                    var currentTemp = nodeStack.Pop().right;

                    if (currentTemp != null)
                    {
                        nodeStack.Push(currentTemp);
                        current = currentTemp;
                        continue;
                    }

                    while (true)
                    {
                        if (nodeStack.Count > 0)
                        {
                            current = nodeStack.Pop();
                            rusultList.Add(current.val);
                        }
                        else
                        {
                            if (current.right == null)
                            {
                                break;
                            }
                        }

                        if (current.right != null)
                        {
                            current = current.right;
                            nodeStack.Push(current);
                            break;
                        }
                    }
                }

                if (nodeStack.Count == 0)
                {
                    return rusultList;
                }
            }
        }
    }

    class TestDataForBinaryTreeInorderTraversal
    {
        public TreeNode GetRoot1()
        {
            TreeNode root1 = new TreeNode(1);
            root1.left = new TreeNode(2);
            root1.right = new TreeNode(3);
            root1.left.left = new TreeNode(4);
            root1.left.right = new TreeNode(5);
            root1.right.right = new TreeNode(8);
            root1.left.right.left = new TreeNode(6);
            root1.left.right.right = new TreeNode(7);
            root1.right.right.left = new TreeNode(9);

            return root1;
        }

        public TreeNode GetRoot2() 
        {
            TreeNode root2 = new TreeNode(2);
            root2.left = new TreeNode(3);
            root2.left.left = new TreeNode(1);

            return root2;
        }

        public TreeNode GetRoot3()
        {
            TreeNode root3 = new TreeNode(3);
            root3.left = new TreeNode(1);
            root3.left.right = new TreeNode(2);

            return root3;
        }
    }
}
