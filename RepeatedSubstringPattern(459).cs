using System.Text;

namespace LeetCode
{
    partial class Solution
    {
        public bool RepeatedSubstringPattern(string s)
        {
            if (s.Length == 1)
            {
                return false;
            }

            if (s.Distinct().Count() == 1)
            {
                return true;
            }

            var compStrSb = new StringBuilder();

            for (int i = 1; i < s.Length / 2; i++)
            {
                if (s.Length % (i + 1) == 0)
                {
                    string subStr = s.Substring(0, i + 1);
                    
                    for (int j = 0; j < s.Length / (i + 1); j++)
                    {
                        compStrSb.Append(subStr);
                    }

                    if (compStrSb.ToString() == s)
                    {
                        return true;
                    }

                    compStrSb.Clear();
                }
            }

            return false;
        }
    }
}
