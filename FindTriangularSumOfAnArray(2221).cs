namespace LeetCode
{
    partial class Solution
    {
        public int TriangularSum(int[] nums)
        {
            int rowNumber = nums.Length;
            int[] row;

            while (rowNumber != 1)
            {
                row = new int[rowNumber - 1];

                for (int i = 0; i < rowNumber - 1; i++)
                {
                    row[i] = (nums[i] + nums[i + 1]) % 10;
                }

                nums = row;
                rowNumber--;
            }

            return nums[0];
        }
    }
}
