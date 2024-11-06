namespace LeetCode
{
    partial class Solution
    {
        public int[] IntersectII(int[] nums1, int[] nums2)
        {
            var result = new List<int>();

            foreach (var num in nums1.Distinct())
            {
                int count1 = nums1.Count(x => x == num);
                int count2 = nums2.Count(x => x == num);

                for (int i = 0; i < (count1 < count2 ? count1 : count2); i++)
                {
                    result.Add(num);
                }
            }

            return result.ToArray();
        }
    }
}
