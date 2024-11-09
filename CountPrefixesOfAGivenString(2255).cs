using System.Linq;

namespace LeetCode
{
    partial class Solution
    {
        public int CountPrefixes(string[] words, string s)
        {
            return words.Where(word => s.StartsWith(word)).Count();
        }
    }
}
