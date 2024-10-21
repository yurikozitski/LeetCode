namespace LeetCode
{
    partial class Solution
    {       
        public IList<IList<int>> HasPathSumII(TreeNode root, int targetSum)
        {
            var result = new List<IList<int>>();

            if (root == null)
            {
                return result;
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
                        var pathList = new List<int>();

                        foreach (var value in nodeStack)
                        {
                            pathList.Add(value.node.val);
                        }

                        pathList.Reverse();
                        pathList.Add(current.node.val);
                        result.Add(pathList);
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
                    return result;
                }
            }
        }
    }

    static class TestDataForPathSumII
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
