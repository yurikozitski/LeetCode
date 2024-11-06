namespace LeetCode
{
    partial class Solution
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            var num1Set = new HashSet<int>();
            var result = new List<int>();

            foreach (var num in nums1)
            {
                num1Set.Add(num);
            }

            result.AddRange(nums2.Where(num => num1Set.Remove(num)));

            return result.ToArray();
        }
    }
}
