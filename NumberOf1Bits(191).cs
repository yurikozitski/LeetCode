namespace LeetCode
{
    partial class Solution
    {
        public int HammingWeight(int n)
        {
            string binary = Convert.ToString(n, 2);
            int count = 0;

            foreach (var bit in binary)
            {
                if (bit == '1')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
