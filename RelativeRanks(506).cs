namespace LeetCode
{
    partial class Solution
    {
        public string[] FindRelativeRanks(int[] score)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < score.Length; i++)
            {
                dict.Add(score[i], i);
            }

            score = score.OrderByDescending(c => c).ToArray();

            string[] result = new string[score.Length];

            for (int i = 0; i < score.Length; i++)
            {
                result[dict[score[i]]] = i switch
                {
                    0 => "Gold Medal",
                    1 => "Silver Medal",
                    2 => "Bronze Medal",
                    _ => (i + 1).ToString(),
                };
            }

            return result;
        }
    }
}
