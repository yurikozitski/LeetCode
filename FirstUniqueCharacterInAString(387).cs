namespace LeetCode
{
    partial class Solution
    {
        public int FirstUniqChar(string s)
        {
            var chrDict= new Dictionary<char, int>();
            var nonUniques = new HashSet<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!nonUniques.Contains(s[i]) && !chrDict.TryAdd(s[i], i))
                {
                    chrDict.Remove(s[i]);
                    nonUniques.Add(s[i]);
                }
            }

            return chrDict.Count != 0 ? chrDict.Values.Min() : -1;
        }
    }
}
