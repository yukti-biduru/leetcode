namespace Leetcode.Solutions
{
    internal class WordBreakII
    {
        public IList<string> WordBreak(string s, IList<string> wordDict)
        {
            HashSet<string> words = new HashSet<string>(wordDict);
            List<string>[] dp = new List<string>[s.Length + 1];
            dp[0] = new List<string> { "" };
            for (int i = 1; i <= s.Length; i++)
            {
                List<string> list = new List<string>();
                for (int j = 0; j < i; j++)
                {
                    string word = s.Substring(j, i - j);
                    if (dp[j] != null && words.Contains(word))
                    {
                        foreach (string sent in dp[j])
                        {
                            list.Add((sent + " " + word).Trim());
                        }
                    }

                }
                dp[i] = list.Count > 0 ? list : null;
            }
            return dp[s.Length] ?? new List<string>();
        }
    }
}
