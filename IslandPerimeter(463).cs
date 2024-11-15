namespace LeetCode
{
    partial class Solution
    {
        public int IslandPerimeter(int[][] grid)
        {
            int per = 0;
            int minI = 0;
            int maxI = grid.Length - 1;
            int minJ = 0;
            int maxJ = grid[0].Length - 1;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        int prevI = i - 1;
                        int nextI = i + 1;
                        int prevJ = j - 1;
                        int nextJ = j + 1;

                        if (prevI < minI)
                        {
                            per++;
                        }
                        else
                        {
                            if (grid[prevI][j] == 0)
                            {
                                per++;
                            }
                        }

                        if (nextI > maxI)
                        {
                            per++;
                        }
                        else
                        {
                            if (grid[nextI][j] == 0)
                            {
                                per++;
                            }
                        }

                        if (prevJ < minJ)
                        {
                            per++;
                        }
                        else
                        {
                            if (grid[i][prevJ] == 0)
                            {
                                per++;
                            }
                        }

                        if (nextJ > maxJ)
                        {
                            per++;
                        }
                        else
                        {
                            if (grid[i][nextJ] == 0)
                            {
                                per++;
                            }
                        }
                    }
                }
            }

            return per;
        }
    }
}
