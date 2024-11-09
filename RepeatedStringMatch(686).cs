using System.Text;

namespace LeetCode
{
    partial class Solution
    {
        public int RepeatedStringMatch(string a, string b)
        {
            var aSb = new StringBuilder(a);
            int count = 1;

            while (aSb.Length < b.Length * 2 + a.Length * 2)
            {
                if (aSb.ToString().Contains(b))
                {
                    return count;
                }

                aSb.Append(a); 
                count++;
            }

            return -1;
        }
    }
}
