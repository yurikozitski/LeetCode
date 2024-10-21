namespace LeetCode
{
    partial class Solution
    {
        public int SingleNumberII(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }

            Array.Sort(nums);

            for (int i = 1; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1] && nums[i] != nums[i - 1])
                {
                    return nums[i];
                }
            }

            if (nums[0] != nums[1])
            {
                return nums[0];
            }

            if (nums[nums.Length - 1] != nums[nums.Length - 2])
            {
                return nums[nums.Length - 1];
            }

            return 0;
        }
    }
}
