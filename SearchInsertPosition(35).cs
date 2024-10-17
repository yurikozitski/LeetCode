namespace LeetCode
{
    partial class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            if (nums[0] > target)
            {
                return 0;
            }

            if (nums[nums.Length - 1] < target)
            {
                return nums.Length;
            }

            double devider = 2;
            int searchingPos = 0;

            if (nums.Length % 2 == 0)
                searchingPos = (int)Math.Round(nums.Length / devider, MidpointRounding.AwayFromZero);
            if (nums.Length % 2 != 0)
                searchingPos = (int)Math.Round(nums.Length / devider, MidpointRounding.ToZero);

            int shift;

            while (nums[searchingPos] != target)
            {
                devider *= 2;
                shift = (int)Math.Round(nums.Length / devider, MidpointRounding.AwayFromZero);

                if (nums[searchingPos] > target)
                {
                    searchingPos -= shift;
                }
                else if (nums[searchingPos] < target)
                {
                    searchingPos += shift;
                }

                if (searchingPos >= nums.Length || shift == 0)
                {
                    if (nums[searchingPos] > target)
                    {
                        return searchingPos;
                    }
                    else if (nums[searchingPos] < target)
                    {
                        return searchingPos + 1;
                    }
                    else
                    {
                        return searchingPos;
                    }
                }
            }

            return searchingPos;
        }
    }
}
