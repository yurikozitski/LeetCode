namespace LeetCode
{
    partial class Solution
    {
        public IList<int> GetRow(int rowIndex)
        {
            var result = new List<IList<int>>();

            for (int i = 0; i <= rowIndex; i++)
            {
                var row = new List<int>();

                for (int j = 0; j <= i; j++)
                {
                    if (i == 0 || j == 0 || j == i)
                    {
                        row.Add(1);
                    }
                    else
                    {
                        int aboveLeft = result[i - 1][j - 1];
                        int aboveRight = result[i - 1][j];

                        row.Add(aboveLeft + aboveRight);
                    }

                }

                result.Add(row);
            }

            return result[result.Count - 1];
        }
    }
}
