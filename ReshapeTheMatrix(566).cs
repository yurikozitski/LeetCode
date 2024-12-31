namespace LeetCode
{
    partial class Solution
    {
        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            int length = 0;

            for (int i = 0; i < mat.Length; i++)
            {
                length += mat[i].Length;
            }

            if (r * c != length)
            {
                return mat;
            }

            int[][] res = new int[r][];

            for (int i = 0; i < r; i++)
            {
                res[i] = new int[c];
            }

            int count = 1;
            int resRow = 0;
            int resCol = 0;

            foreach (int[] array in mat)
            {
                foreach (int value in array)
                {
                    res[resRow][resCol] = value;
                    resCol++;

                    if (count % c == 0)
                    {
                        resRow++;
                        resCol = 0;
                    }

                    count++;
                }
            }

            return res;
        }
    }
}
