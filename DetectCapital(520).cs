namespace LeetCode
{
    partial class Solution
    {
        public bool DetectCapitalUse(string word)
        {
            if (word.ToUpper() == word ||
                word.ToLower() == word ||
                word.Substring(1) == word.Substring(1).ToLower())
            {
                return true;
            }

            return false;
        }
    }
}
