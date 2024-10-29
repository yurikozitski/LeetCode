namespace LeetCode
{
    partial class Solution
    {
        //NOT ACCEPTED
        //public int FindDuplicate(int[] nums)
        //{
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        for (int j = i + 1; j < nums.Length; j++)
        //        {
        //            if (nums[i] == nums[j])
        //            {
        //                return nums[i];
        //            }
        //        }
        //    }

        //    return 0;
        //}

        public int FindDuplicate(int[] nums)
        {
            int slow = nums[0];
            int fast = nums[0];

            do
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
            } 
            while (slow != fast);

            fast = nums[0];

            while (slow != fast)
            {
                slow = nums[slow];
                fast = nums[fast];
            }

            return slow;
        }
    }
}
