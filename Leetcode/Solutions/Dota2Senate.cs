namespace Leetcode.Solutions
{
    internal class Dota2Senate
    {
        // https://leetcode.com/problems/dota2-senate/description/
        public string PredictPartyVictory(string senate)
        {
            Queue<int> rad = new Queue<int>();
            Queue<int> dire = new Queue<int>();
            for (int i = 0; i < senate.Length; i++)
            {
                if (senate[i] == 'R')
                {
                    rad.Enqueue(i);
                }
                if (senate[i] == 'D')
                {
                    dire.Enqueue(i);
                }
            }
            for (int i = 0; i < senate.Length; i++)
            {
                if (rad.Count == 0 || dire.Count == 0)
                {
                    break;
                }
                else
                {
                    if (senate[i] == 'R' && rad.Contains(i))
                    {
                        dire.Dequeue();
                    }
                    if (senate[i] == 'D' && dire.Contains(i))
                    {
                        rad.Dequeue();
                    }
                }
            }
            Console.WriteLine(dire.Count);
            Console.WriteLine(rad.Count);

            return rad.Count < dire.Count ? "Dire" : "Radiant";
        }
    }
}
