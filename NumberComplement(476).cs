namespace LeetCode
{
    partial class Solution
    {
        public int FindComplement(int num)
        {
            int shift = 32 - Convert.ToString(num, toBase: 2).Length;
            int n = ~num << shift;
            return n >> shift;
        }
    }
}
