namespace LeetCode
{
    partial class Solution
    {
        public string[] FindWords(string[] words)
        {
            Dictionary<char, int> keyboardDict = new Dictionary<char, int>(); 

            string row1 = "qwertyuiop"; 

            foreach (char c in row1) 
            { 
                keyboardDict[c] = 1; 
            }  

            string row2 = "asdfghjkl"; 

            foreach (char c in row2) 
            { 
                keyboardDict[c] = 2; 
            } 

            string row3 = "zxcvbnm"; 

            foreach (char c in row3) 
            { 
                keyboardDict[c] = 3; 
            }

            var result = new List<string>();

            foreach (var word in words)
            {
                if (word.GroupBy(c => keyboardDict[char.ToLower(c)]).Count() == 1)
                {
                    result.Add(word);
                }
            }

            return result.ToArray();
        }
    }
}
