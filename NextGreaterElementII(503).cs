namespace LeetCode
{
    partial class Solution
    {
        public int[] NextGreaterElements(int[] nums)
        {
            var result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int j = i + 1;

                while (true)
                {
                    if (j == nums.Length)
                    {
                        j = 0;
                    }

                    if (nums[j] > nums[i])
                    {
                        result.Add(nums[j]);
                        break;
                    }

                    if (i == j)
                    {
                        result.Add(-1);
                        break;
                    }

                    j++;
                }
            }

            return result.ToArray();
        }
    }
}
