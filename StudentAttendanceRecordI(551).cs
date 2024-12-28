namespace LeetCode
{
    partial class Solution
    {
        public bool CheckRecord(string s)
        {
            int absentCount = 0;
            int lateInRowCount = 0;

            foreach (var chr in s)
            {
                if (chr == 'A')
                {
                    absentCount++;
                }

                if (chr == 'L')
                {
                    lateInRowCount++;
                }
                else
                {
                    lateInRowCount = 0;
                }

                if (absentCount >= 2 || lateInRowCount >= 3)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
