namespace LeetCode
{
    partial class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int notValCount = nums.Length;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    nums[i] = int.MaxValue;
                    notValCount--;
                }
            }

            Array.Sort(nums);

            return notValCount;
        }
    }
}
