namespace Leetcode.Solutions
{
    internal class ReversePrefixOfWord
    {
        public string ReversePrefix(string word, char ch)
        {
            List<char> chars = word.ToList();
            int index = chars.IndexOf(ch);
            if (index == -1)
            {
                return word;
            }
            string res = "";
            for (int i = index; i >= 0; i--)
            {
                res += word[i];
            }

            for (int i = index + 1; i < word.Length; i++)
            {
                res += word[i];
            }
            return res;
        }
    }
}
