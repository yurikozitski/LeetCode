using System.Text;

namespace LeetCode
{
    partial class Solution
    {
        public bool RotateString(string s, string goal)
        {
            var sArr = s.ToCharArray();
            var sb = new StringBuilder();

            for (int i = 0; i < sArr.Length; i++)
            {
                char temp = sArr[0];

                for (int j = 0; j < sArr.Length; j++)
                {
                    if (j != sArr.Length - 1)
                    {
                        sArr[j] = sArr[j + 1];
                    }
                    else
                    {
                        sArr[j] = temp;
                    }
                }

                foreach (var chr in sArr)
                {
                    sb.Append(chr);
                }

                if (sb.ToString() == goal)
                {
                    return true;
                }

                sb.Clear();
            }

            return false;
        }
    }
}
