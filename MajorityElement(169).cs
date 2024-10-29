namespace LeetCode
{
    partial class Solution
    {
        public int MajorityElement(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }

            int n = nums.Length / 2;

            Array.Sort(nums);

            return nums[n];
        }
    }
}
