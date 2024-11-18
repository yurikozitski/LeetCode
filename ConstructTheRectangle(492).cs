namespace LeetCode
{
    partial class Solution
    {
        public int[] ConstructRectangle(int area)
        {
            int[] result = new int[2];
            double width = Math.Floor(Math.Sqrt((double)area));

            while (width >= 1)
            {
                if (area % width == 0d)
                {
                    result[0] = (int)(area / width);
                    result[1] = (int)width;
                    break;
                }

                width--;
            }

            return result;
        }
    }
}
