namespace LeetCode
{
    partial class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var result = new List<IList<int>>();

            for (int i = 1; i <= numRows; i++)
            {
                var row = new List<int>();

                for (int j = 1; j <= i; j++)
                {
                    if (i == 1 || j == 1 || j == i)
                    {
                        row.Add(1);
                    }
                    else
                    {
                        int aboveLeft = result[i - 2][j - 2];
                        int aboveRight = result[i - 2][j - 1];

                        row.Add(aboveLeft + aboveRight);
                    }

                }

                result.Add(row);
            }

            return result;
        }
    }
}
