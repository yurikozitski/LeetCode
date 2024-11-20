
namespace LeetCode
{
    partial class Solution
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            var nums2Dict = new Dictionary<int, int>();
            var result = new List<int>();

            for (int i = 0; i < nums2.Length; i++)
            {
                nums2Dict.Add(nums2[i], i);        
            }
            
            foreach (var num1 in nums1)
            {
                int num2Index = nums2Dict[num1];
                bool hasGreaterEl = false;

                for (int i = num2Index + 1; i < nums2.Length; i++)
                {
                    if (nums2[i] > num1)
                    {
                        result.Add(nums2[i]);
                        hasGreaterEl = true;
                        break;
                    }
                }

                if (!hasGreaterEl)
                {
                    result.Add(-1);
                }
            }

            return result.ToArray();
        }
    }
}
