using System.Text;

namespace LeetCode
{
    partial class Solution
    {
        public string SmallestFromLeaf(TreeNode root)
        {
            string result = string.Empty;
            Dictionary<int, char> alphabetDict = new Dictionary<int, char>();

            for (int i = 0; i <= 25; i++)
            {
                alphabetDict.Add(i, (char)('a' + i));
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

                    var pathListSb = new StringBuilder();

                    pathListSb.Append(alphabetDict[current.node.val]);

                    foreach (var value in nodeStack)
                    {
                        pathListSb.Append(alphabetDict[value.node.val]);
                    }

                    string pathList = pathListSb.ToString();

                    if (string.IsNullOrEmpty(result) || CompareStrings(pathList, result) < 0)
                    {
                        result = pathList;
                    }

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

            int CompareStrings(string str1, string str2)
            {
                int minLength = Math.Min(str1.Length, str2.Length);

                for (int i = 0; i < minLength; i++)
                {
                    if (str1[i] < str2[i])
                    {
                        return -1; // str1 is lexicographically smaller
                    }
                    if (str1[i] > str2[i])
                    {
                        return 1; // str1 is lexicographically larger
                    }
                }

                if (str1.Length < str2.Length)
                {
                    return -1; // str1 is shorter and thus smaller
                }
                if (str1.Length > str2.Length)
                {
                    return 1; // str1 is longer and thus larger
                }

                return 0; // Strings are equal
            }
        }
    }

    static class DataForSmallestFromLeaf
    {
        public static TreeNode CreateTree()
        {
            TreeNode root = new TreeNode(25);

            root.left = new TreeNode(1);
            root.right = new TreeNode(3);

            root.left.left = new TreeNode(1);
            root.left.right = new TreeNode(3);

            root.right.left = new TreeNode(0);
            root.right.right = new TreeNode(2);

            return root;
        }
    }
}
