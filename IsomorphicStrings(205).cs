namespace LeetCode
{
    partial class Solution
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.ToCharArray().Distinct().Count() != t.ToCharArray().Distinct().Count())
            {
                return false;
            }

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j] && t[i] != t[j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
