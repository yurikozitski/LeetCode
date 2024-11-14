namespace LeetCode
{
    partial class Solution
    {
        public int HammingDistance(int x, int y)
        {
            int xored = x ^ y;
            int bitCount = 0;

            while (xored > 0)
            {
                if (xored % 2 != 0)
                {
                    bitCount++;
                }

                xored /= 2;
            }

            return bitCount;
        }
    }
}
