namespace LeetCode
{
    partial class Solution
    {
        //O(n^2) Complexity
        //public int MaxProfit(int[] prices)
        //{
        //    int profit = 0;

        //    for (int i = 0; i < prices.Length; i++)
        //    {
        //        for (int j = i + 1; j < prices.Length; j++)
        //        {
        //            int tempProfit = prices[j] - prices[i];

        //            if (tempProfit > profit)
        //            {
        //                profit = tempProfit;
        //            }
        //        }
        //    }

        //    return profit;
        //}


        //Not working
        //public int MaxProfit(int[] prices)
        //{
        //    int profit = 0;
        //    int maxValue;
        //    int maxValueIndex;

        //    while (true)
        //    {
        //        maxValue = prices.Max();
        //        maxValueIndex = prices.ToList().IndexOf(maxValue);

        //        if (maxValueIndex < 1)
        //        {
        //            prices = prices.Skip(1).ToArray();
        //        }
        //        else
        //        {
        //            break;
        //        }

        //        if (prices.Length < 2)
        //        {
        //            break;
        //        }
        //    }

        //    var minValueArray = prices.Take(maxValueIndex);

        //    if (minValueArray.Any())
        //    {
        //        int minValue = minValueArray.Min();
        //        profit = maxValue - minValue;
        //    }

        //    return profit;
        //}

        public int MaxProfit(int[] prices)
        {
            if (prices.Length < 2) 
            {  
                return 0; 
            }

            int profit = 0;
            int tempProfit = 0;
            int bottom = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {             
                if (prices[i] < prices[i - 1] && tempProfit > profit)
                {
                    profit = tempProfit;
                }

                if (prices[i] < bottom)
                {
                    bottom = prices[i];
                    tempProfit = 0;
                }
                else
                {
                    tempProfit += prices[i] - prices[i - 1];
                }

                if (i == prices.Length - 1 && tempProfit > profit)
                {
                    profit = tempProfit;
                }
            }

            return profit;
        }
    }
}
