namespace LeetCode
{
    partial class Solution
    {
        public bool SatisfiesConditions(int[][] grid)
        {
            for (int i = 0; i < grid[0].Length; i++)
            {
                for (int j = 0; j < grid.Length; j++)
                {
                    if (j + 1 != grid.Length && grid[j][i] != grid[j + 1][i] ||
                        i + 1 != grid[j].Length && grid[j][i] == grid[j][i + 1])
                    {
                        return false;
                    }                  
                }
            }

            return true;
        }
    }
}
