namespace LeetCode
{
    partial class Solution
    {
        public bool IsValid(string s)
        {
            var chrArray = s.ToCharArray();
            var chrStack = new Stack<char>();

            foreach (var chr in chrArray)
            {
                if (chr == '(' || chr == '[' || chr == '{')
                {
                    chrStack.Push(chr);
                }

                if (chr == ')')
                {
                    bool isAnyOpeningBracket = chrStack.TryPop(out char topChr);

                    if (!isAnyOpeningBracket || topChr != '(')
                        return false;
                }

                if (chr == ']')
                {
                    bool isAnyOpeningBracket = chrStack.TryPop(out char topChr);

                    if (!isAnyOpeningBracket || topChr != '[')
                        return false;
                }

                if (chr == '}')
                {
                    bool isAnyOpeningBracket = chrStack.TryPop(out char topChr);

                    if (!isAnyOpeningBracket || topChr != '{')
                        return false;
                }
            }

            return chrStack.Count == 0;
        }
    }
}
