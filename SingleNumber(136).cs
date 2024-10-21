namespace LeetCode
{
    partial class Solution
    {
        public int SingleNumber(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i+=2)
            {
                if (i != nums.Length - 1 && nums[i] != nums[i + 1])
                {
                    return nums[i];
                }
            }

            return nums[nums.Length - 1];
        }
    }
}
