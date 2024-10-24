namespace LeetCode
{
    partial class Solution
    {
        public uint reverseBits(uint n)
        {
            string binaryString = Convert.ToString(n, 2);

            if (binaryString.Length < 32)
            {
                string leadingZeroes = new string('0', 32 - binaryString.Length);
                binaryString = leadingZeroes + binaryString;
            }

            string reversedBinaryString = string.Join(string.Empty, binaryString.Reverse().Select(c => c).ToArray());

            return Convert.ToUInt32(reversedBinaryString, 2);
        }
    }
}
