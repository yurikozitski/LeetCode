namespace LeetCode
{
    partial class Solution
    {
        public int CountDigits(int num)
        {
            int res = 0;
            int n = num;

            while (n != 0)
            {
                int digit = n % 10;

                if (!(digit == 0 || num % digit != 0))
                {
                    res++;
                }

                n /= 10;
            }

            return res;
        }
    }
}
