namespace LeetCode
{
    partial class Solution
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            var result = new List<int>();
            var uniqueNums = new HashSet<int>();

            foreach (var num in nums)
            {
                if (!uniqueNums.Add(num))
                {
                    result.Add(num);
                }
            }

            return result;
        }
    }
}
