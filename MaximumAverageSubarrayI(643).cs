namespace LeetCode
{
    partial class Solution
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            double maxAvg = double.MinValue;
            int firstIndex = 0;
            int lastIndex = firstIndex + k;
            double sum = 0d;

            for (int i = firstIndex; i < lastIndex; i++)
            {
                sum += nums[i];
            }

            while (true)
            {                                
                double avg = Math.Round(sum / k, 5);

                if (avg > maxAvg)
                {
                    maxAvg = avg;
                }

                sum -= nums[firstIndex];

                if (lastIndex < nums.Length)
                {
                    sum += nums[lastIndex];
                }
                else
                {
                    break;
                }

                firstIndex++;
                lastIndex++;
            }
            
            return maxAvg;
        }
    }
}
