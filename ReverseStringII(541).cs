using System.Text;

namespace LeetCode
{
    partial class Solution
    {
        public string ReverseStr(string s, int k)
        {
            int counter = 0;
            bool isReversed = true;
            var substringSb = new StringBuilder();
            var resultSb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                counter++;               
                substringSb.Append(s[i]);

                if (counter == k || i == s.Length - 1)
                {
                    if (isReversed)
                    {
                        string reversedSubStr = string.Join(string.Empty, substringSb.ToString().Reverse());
                        resultSb.Append(reversedSubStr);                        
                    }
                    else
                    {
                        resultSb.Append(substringSb.ToString());
                    }

                    substringSb.Clear();
                    counter = 0;
                    isReversed = !isReversed;
                }
            }

            return resultSb.ToString();
        }
    }
}
