namespace LeetCode
{
    partial class Solution
    {
        public int DistributeCandies(int[] candyType)
        {
            int numberOfTypes = candyType.Distinct().Count();
            int numberOfCandies = candyType.Length;

            if (numberOfTypes <= numberOfCandies / 2)
            {
                return numberOfTypes;
            }
            else
            {
                return numberOfCandies / 2;
            }
        }
    }
}
