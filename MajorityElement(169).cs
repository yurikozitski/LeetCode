namespace LeetCode
{
    partial class Solution
    {
        //Default Solution with Sorting 
        //public int MajorityElement(int[] nums)
        //{
        //    if (nums.Length == 1)
        //    {
        //        return nums[0];
        //    }

        //    int n = nums.Length / 2;

        //    Array.Sort(nums);

        //    return nums[n];
        //}

        //Boyer–Moore majority vote algorithm
        public int MajorityElement(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }

            int majority = nums[0];
            int majorityCount = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == majority)
                {
                    majorityCount++;
                }
                else
                {
                    majorityCount--;
                }

                if (majorityCount == 0)
                {
                    majority = nums[i];
                    majorityCount = 1;
                }
            }

            return majority;
        }
    }
}
