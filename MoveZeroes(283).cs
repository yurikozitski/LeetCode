namespace LeetCode
{
    partial class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            var nonZeroes = new List<int>();

            foreach (var num in nums)
            {
                if (num != 0)
                {
                    nonZeroes.Add(num);
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (i < nums.Length - (nums.Length - nonZeroes.Count))
                {
                    nums[i] = nonZeroes[i];
                }
                else
                {
                    nums[i] = 0;
                }
            }
        }
    }
}
