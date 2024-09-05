namespace Leetcode.Solutions
{
    internal class MinimumMovesToConvertString
    {
        public int MinimumMoves(string s)
        {
            int moves = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'X')
                {
                    moves++;
                    i += 2;
                }
            }
            return moves;
        }
    }
}
