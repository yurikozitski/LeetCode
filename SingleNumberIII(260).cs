namespace LeetCode
{
    partial class Solution
    {
        public int[] SingleNumberIII(int[] nums)
        {
            if (nums.Length == 1)
            {
                return [nums[0]];
            }

            Array.Sort(nums);
            var result = new List<int>();

            for (int i = 1; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1] && nums[i] != nums[i - 1])
                {
                    result.Add(nums[i]);
                }
            }

            if (nums[0] != nums[1])
            {
                result.Add(nums[0]);
            }

            if (nums[nums.Length - 1] != nums[nums.Length - 2])
            {
                result.Add(nums[nums.Length - 1]);
            }

            return result.ToArray();
        }
    }
}
