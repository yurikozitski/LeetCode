using System.Text;

namespace LeetCode
{
    partial class Solution
    {
        public string AddStrings(string num1, string num2)
        {
            int diff = num1.Length - num2.Length;

            if (diff > 0)
            {
                num2 = new string('0', diff) + num2;
            }
            else if (diff < 0)
            {
                num1 = new string('0', -diff) + num1;
            }

            var resultStack = new Stack<byte>();
            var resultSb = new StringBuilder();
            byte overhead = 0;

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                byte n1 = Convert.ToByte(num1[i].ToString());
                byte n2 = Convert.ToByte(num2[i].ToString());
                byte sum = (byte)(n1 + n2 + overhead);

                if (sum < 10)
                {
                    resultStack.Push(sum);
                    overhead = 0;
                }
                else
                {
                    resultStack.Push((byte)(sum - 10));
                    overhead = 1;
                }
            }

            if (overhead == 1)
            {
                resultStack.Push(1);
            }

            while (resultStack.Count > 0)
            {
                resultSb.Append(resultStack.Pop());
            }

            return resultSb.ToString();
        }
    }
}
