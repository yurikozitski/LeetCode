namespace LeetCode
{
    partial class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int uniqueElCount = nums.Length;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    nums[i] = int.MaxValue;
                    uniqueElCount--;
                }
            }

            Array.Sort(nums);

            return uniqueElCount;
        }
    }
}
