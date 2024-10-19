namespace LeetCode
{
    partial class Solution
    {
        // not working, has bug
        //public bool HasPathSum(TreeNode root, int targetSum)
        //{
        //    if (root == null)
        //    {
        //        return false;
        //    }

        //    int sum = 0;
        //    var nodeStack = new Stack<TreeNode>();
        //    TreeNode current = root;
        //    nodeStack.Push(current);
        //    sum += current.val;

        //    while (true)
        //    {
        //        if (current.left != null)
        //        {
        //            current = current.left;
        //            nodeStack.Push(current);
        //            sum += current.val;
        //        }
        //        else
        //        {
        //            var currentTemp = nodeStack.Peek().right;

        //            if (currentTemp != null)
        //            {
        //                current = currentTemp;
        //                nodeStack.Push(current);
        //                sum += current.val;
        //                continue;
        //            }
        //            else
        //            {
        //                nodeStack.Pop();
        //            }

        //            if (sum == targetSum)
        //            {
        //                return true;
        //            }

        //            sum -= current.val;


        //            while (true)
        //            {
        //                if (nodeStack.Count > 0)
        //                {
        //                    current = nodeStack.Peek();

        //                    if (current.right == null)
        //                    {
        //                        nodeStack.Pop();
        //                    }
        //                }
        //                else
        //                {
        //                    if (current.right == null)
        //                    {
        //                        sum -= current.val;
        //                        break;
        //                    }
        //                }

        //                if (current.right != null)
        //                {
        //                    var temp = current.right;
        //                    current.right = null!;
        //                    current = temp;
        //                    nodeStack.Push(current);
        //                    sum += current.val;
        //                    break;
        //                }
        //                else
        //                {
        //                    sum -= current.val;
        //                }
        //            }
        //        }

        //        if (nodeStack.Count == 0)
        //        {
        //            return false;
        //        }
        //    }
        //}

        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
            {
                return false;
            }

            int sum = 0;
            var nodeStack = new Stack<(TreeNode node, bool passed)>();
            var current = (node: root, passed: false);
            nodeStack.Push(current);
            sum += current.node.val;

            while (true)
            {
                if (current.node.left != null)
                {
                    current = (current.node.left, false);
                    nodeStack.Push(current);
                    sum += current.node.val;
                }
                else
                {
                    var currentTemp = nodeStack.Peek();

                    if (currentTemp.node.right != null)
                    {
                        nodeStack.Pop();
                        nodeStack.Push((currentTemp.node, true));

                        current = (currentTemp.node.right, false);
                        nodeStack.Push(current);
                        sum += current.node.val;
                        continue;
                    }
                    else
                    {
                        nodeStack.Pop();
                    }

                    if (sum == targetSum)
                    {
                        return true;
                    }

                    sum -= current.node.val;

                    while (true)
                    {
                        if (nodeStack.Count > 0)
                        {
                            current = nodeStack.Peek();

                            if (current.node.right == null || current.passed)
                            {
                                nodeStack.Pop();
                            }
                        }
                        else
                        {
                            break;
                        }

                        if (current.node.right != null && !current.passed)
                        {
                            nodeStack.Pop();
                            nodeStack.Push((current.node, true));

                            current = (current.node.right, false);
                            nodeStack.Push(current);
                            sum += current.node.val;
                            break;
                        }
                        else
                        {
                            sum -= current.node.val;
                        }
                    }
                }

                if (nodeStack.Count == 0)
                {
                    return false;
                }
            }
        }
    }

    static class TestDataForPathSum
    {
        public static TreeNode GetRoot1()
        {
            TreeNode root = new TreeNode(1);

            root.left = new TreeNode(2);
            root.right = new TreeNode(3);


            return root;
        }
    }
}
