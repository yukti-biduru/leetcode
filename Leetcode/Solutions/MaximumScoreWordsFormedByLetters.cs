namespace Leetcode.Solutions
{
    internal class MaximumScoreWordsFormedByLetters
    {
        public int MaxScoreWords(string[] words, char[] letters, int[] score)
        {
            List<char> chars = new List<char>(letters);
            Array.Sort(letters);
            string s = new string(letters);
            List<string>[] dp = new List<string>[letters.Length + 1];
            dp[0] = new List<string> { "" };

            for (int i = 1; i <= letters.Length; i++)
            {
                List<string> list = new List<string>();
                for (int j = 0; j < i; j++)
                {
                    string str = s.Substring(j, i - j);
                    foreach (string word in words)
                    {
                        char[] temp = word.ToCharArray();
                        Array.Sort(temp);
                        string str2 = new string(temp);
                        if (str.CompareTo(str2) == 0)
                        {

                        }
                    }
                }
                dp[i] = (list);
            }

            return 0;
        }
    }
}
