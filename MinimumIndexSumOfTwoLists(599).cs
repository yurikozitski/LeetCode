namespace LeetCode
{
    partial class Solution
    {
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            var list2Dict = new Dictionary<string, int>();

            for (int i = 0; i < list2.Length; i++)
            {                
                list2Dict[list2[i]] = i;                
            }

            List<(string Word, int IndexSum)> wordIndexList = new();

            for (int i = 0; i < list1.Length; i++)
            {
                int list2Index = 0;

                if (list2Dict.TryGetValue(list1[i], out list2Index))
                {
                    wordIndexList.Add((list1[i], i + list2Index));
                }
            }

            wordIndexList = wordIndexList.OrderBy(x => x.IndexSum).ToList();

            return wordIndexList
                .Where(x => x.IndexSum == wordIndexList[0].IndexSum)
                .Select(x => x.Word)
                .ToArray();
        }
    }
}
