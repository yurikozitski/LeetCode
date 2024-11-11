namespace LeetCode
{
    partial class Solution
    {
        public bool IsSubsequence(string s, string t)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            if (string.IsNullOrEmpty(t))
            {
                return false;
            }

            int i = 0;

            foreach (var chr in t)
            {
                if (chr == s[i])
                {
                    i++;
                }
                
                if (i == s.Length)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
