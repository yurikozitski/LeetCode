namespace LeetCode
{
    partial class Solution
    {
        public int IsPrefixOfWord(string sentence, string searchWord)
        {
            var sentenceArr = sentence.Split(' ');

            for (int i = 0; i < sentenceArr.Length; i++)
            {
                if (sentenceArr[i].StartsWith(searchWord))
                {
                    return i + 1;
                }
            }

            return -1;
        }
    }
}
