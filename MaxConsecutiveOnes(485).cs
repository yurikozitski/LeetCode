namespace LeetCode
{
    partial class Solution
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int onesCount = 0;
            int maxConsecutiveOnes = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    onesCount++;
                }
                else
                {
                    if (onesCount > maxConsecutiveOnes)
                    {
                        maxConsecutiveOnes = onesCount;
                    }

                    onesCount = 0;
                }
            }

            return maxConsecutiveOnes > onesCount ? maxConsecutiveOnes : onesCount;
        }
    }
}
