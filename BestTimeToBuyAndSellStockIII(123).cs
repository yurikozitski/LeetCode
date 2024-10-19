namespace LeetCode
{
    partial class Solution
    {
        //not working
        public int MaxProfitIII(int[] prices)
        {
            if (prices.Length < 2)
            {
                return 0;
            }

            var profits = new List<int>();
            int tempProfit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < prices[i - 1])
                {
                    profits.Add(tempProfit);
                    tempProfit = 0;
                }
                else
                {
                    tempProfit += prices[i] - prices[i - 1];
                }

                if (i == prices.Length - 1)
                {
                    profits.Add(tempProfit);
                }
            }

            if (profits.Count == 0)
            {
                return 0;
            }

            if (profits.Count == 1)
            {
                return profits[0];
            }

            return profits.OrderByDescending(n => n).Select(n => n).Take(2).Sum();
        }
    }
}
