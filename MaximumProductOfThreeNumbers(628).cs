namespace LeetCode
{
    partial class Solution
    {
        public int MaximumProduct(int[] nums)
        {
            Array.Sort(nums);
            int maxIndex = nums.Length - 1;

            int res1 = nums[maxIndex] * nums[maxIndex - 1] * nums[maxIndex - 2];
            int res2 = nums[0] * nums[1] * nums[maxIndex];

            return int.Max(res1, res2);
        }
    }
}
