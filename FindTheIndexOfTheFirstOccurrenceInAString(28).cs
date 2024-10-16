namespace LeetCode
{
    partial class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            if (haystack == needle)
            {
                return 0;
            }

            if (haystack.Length < needle.Length)
            {
                return -1;
            }   

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0] && haystack.Length - i >= needle.Length)
                {
                    string subStr = haystack.Substring(i, needle.Length);

                    if (subStr == needle)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
    }
}
