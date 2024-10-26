namespace LeetCode
{
    partial class Solution
    {
        public int AddDigits(int num)
        {
            if (num < 10)
            {
                return num;
            }

            var numsArr = num.ToString().ToCharArray();
            int result = 0;

            while (true) 
            {
                foreach (var n in numsArr)
                {
                    result += (int)char.GetNumericValue(n);
                }

                if (result < 10)
                {
                    return result;
                }

                numsArr = result.ToString().ToCharArray();
                result = 0;
            }
        }
    }
}
