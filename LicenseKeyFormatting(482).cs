using System.Text;

namespace LeetCode
{
    partial class Solution
    {
        public string LicenseKeyFormatting(string s, int k)
        {
            s = s.Trim();

            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            char[] sWithNoDashes = string.Join(string.Empty, s.Split('-')).ToUpper().ToCharArray();
            int firstSegmentLength = sWithNoDashes.Length % k;
            int chrCount = 0;
            var result = new StringBuilder();

            for (int i = 0; i < sWithNoDashes.Length; i++)
            {
                result.Append(sWithNoDashes[i]);
                chrCount++;

                if (i != sWithNoDashes.Length - 1 && ((firstSegmentLength != 0 && chrCount == firstSegmentLength) || chrCount == k))
                {
                    result.Append("-");
                    chrCount = 0;
                    firstSegmentLength = 0;
                }
            }

            return result.ToString();
        }
    }
}
