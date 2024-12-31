namespace LeetCode
{
    partial class Solution
    {
        public int[][] Construct2DArray(int[] original, int m, int n)
        {            
            if (m * n != original.Length)
            {
                return new int[0][];
            }

            int[][] res = new int[m][];

            for (int i = 0; i < m; i++)
            {
                res[i] = new int[n];
            }

            int resRow = 0;
            int resCol = 0;

            for (int i = 0; i < original.Length; i++)
            {                
                res[resRow][resCol] = original[i];
                resCol++;

                if ((i + 1) % n == 0)
                {
                    resRow++;
                    resCol = 0;
                }
            }
                            
            return res;
        }
    }
}
