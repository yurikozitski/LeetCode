namespace LeetCode
{
    partial class Solution
    {
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            var result = new List<string>();

            if (root == null)
            {
                return result;
            }

            var nodeStack = new Stack<(TreeNode node, bool passed)>();
            var current = (node: root, passed: false);
            nodeStack.Push(current);

            while (true)
            {
                if (current.node.left != null)
                {
                    current = (current.node.left, false);
                    nodeStack.Push(current);
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
                        continue;
                    }
                    else
                    {
                        nodeStack.Pop();
                    }

                    
                    var pathList = new List<int>();

                    foreach (var value in nodeStack)
                    {
                        pathList.Add(value.node.val);
                    }

                    pathList.Reverse();
                    pathList.Add(current.node.val);
                    result.Add(string.Join("->", pathList.Select(x => x.ToString())));
                    

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
                            break;
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
}
