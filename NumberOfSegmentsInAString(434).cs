namespace LeetCode
{
    partial class Solution
    {
        public int CountSegments(string s)
        {
            string sTrimmed = s.Trim();

            if (string.IsNullOrEmpty(sTrimmed))
            {
                return 0;
            }

            bool isPreviousSpace = false;
            int count = 0;

            foreach (var chr in sTrimmed)
            {
                if (chr == ' ' && !isPreviousSpace)
                {
                    count++;
                    isPreviousSpace = true;
                }
                else if (chr != ' ')
                {
                    isPreviousSpace = false;
                }
            }

            return count + 1;
        }
    }
}
