namespace Leetcode.Solutions
{
    internal class MinimumNumberOfPushesToTypeWord2
    {
        //https://leetcode.com/problems/minimum-number-of-pushes-to-type-word-ii/
        public int MinimumPushes(string word)
        {
            // create dictionary of frequecy of charachter 

            Dictionary<char, int> kp = new Dictionary<char, int>();
            foreach (char c in word)
            {
                if (kp.ContainsKey(c))
                {
                    kp[c]++;
                }
                else
                {
                    kp.Add(c, 1);
                }
            }
            // 2, 3, 4, 5, 6, 7, 8, 9 - eight counts 
            // map the most used letters to the first eight
            // map the next based on frequency  

            var sortedDict = from entry in kp orderby entry.Value descending select entry;

            int place = 2, times = 1, sum = 0;

            foreach (var entry in sortedDict)
            {
                if (place > 9)
                {
                    place = 2;
                    times++;
                }
                sum += entry.Value * times;
                place++;
            }
            return sum;
        }
    }
}
