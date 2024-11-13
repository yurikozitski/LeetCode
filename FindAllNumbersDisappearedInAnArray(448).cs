namespace LeetCode
{
    partial class Solution
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            var result = new List<int>();
            var uniqueNums = nums.ToHashSet();

            for (int i = 1; i <= nums.Length; i++)
            {
                if (!uniqueNums.Contains(i))
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
