using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode
{
    partial class Solution
    {
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            var result = new List<int>();

            for (int i = left; i <= right; i++)
            {
                int num = i;
                bool skip = false;

                while (num != 0)
                {
                    int digit = num % 10;

                    if (digit == 0 || i % digit != 0)
                    {
                        skip = true;
                        break;
                    }

                    num /= 10;
                }

                if (!skip)
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
