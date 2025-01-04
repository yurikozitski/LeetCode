namespace LeetCode
{
    partial class Solution
    {
        //don't pass, time limit exceeded
        public int MaxProduct(int[] nums)
        {
            int product = int.MinValue;
            int subArrayLength = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                int firstIndex = 0;

                while (firstIndex + subArrayLength <= nums.Length)
                {
                    int[] subArray = SubArray(nums, firstIndex, subArrayLength);
                    int subArrayProduct = subArray.Aggregate(1, (acc, x) => acc * x);

                    if (subArrayProduct > product)
                    {
                        product = subArrayProduct;
                    }

                    firstIndex++;
                }

                subArrayLength++;
            }

            int[] SubArray(int[] data, int index, int length)
            {
                int[] result = new int[length];
                Array.Copy(data, index, result, 0, length);
                return result;
            }

            return product;
        }
    }
}
