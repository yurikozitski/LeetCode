namespace LeetCode
{
    partial class Solution
    { 
        public int MaxProfitII(int[] prices)
        {
            if (prices.Length < 2)
            {
                return 0;
            }

            int profit = 0;
            int tempProfit = 0;

            for (int i = 1; i < prices.Length; i++)
            {              
                if (prices[i] < prices[i - 1])
                {
                    profit += tempProfit;
                    tempProfit = 0;
                }
                else
                {
                    tempProfit += prices[i] - prices[i - 1];
                }

                if (i == prices.Length - 1)
                {
                    profit += tempProfit;
                }
            }

            return profit;
        }
    }
}
