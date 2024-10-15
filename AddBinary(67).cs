using System.Text;

namespace LeetCode
{
    partial class Solution
    {
        public string AddBinary(string a, string b)
        {
            int lengthDifference = a.Length - b.Length;

            if (lengthDifference > 0)
            {
                b = new string('0', lengthDifference) + b;
            }
            else if (lengthDifference < 0)
            {
                a = new string('0', -lengthDifference) + a;
            }

            var resultSb = new StringBuilder();
            bool carryover = false;

            for (int i = a.Length - 1; i >= 0; i--)
            {
                if (!carryover)
                {
                    if (a[i] == '0' && b[i] == '0')
                    {
                        resultSb.Append("0");
                    }
                    else if (a[i] == '1' && b[i] == '1')
                    {
                        resultSb.Append("0");
                        carryover = true;
                    }
                    else
                    {
                        resultSb.Append('1');
                    }
                }
                else
                {
                    if (a[i] == '0' && b[i] == '0')
                    {
                        resultSb.Append("1");
                        carryover = false;
                    }
                    else if (a[i] == '1' && b[i] == '1')
                    {
                        resultSb.Append("1");
                    }
                    else
                    {
                        resultSb.Append('0');
                    }
                }

                if (carryover && i == 0)
                {
                    resultSb.Append('1');
                }
            }
            return new string(resultSb.ToString().ToCharArray().Reverse().ToArray());
        }
    }
}
