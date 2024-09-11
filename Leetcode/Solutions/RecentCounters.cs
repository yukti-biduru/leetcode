namespace Leetcode.Solutions
{
    internal class RecentCounters
    {
        public class RecentCounter
        {
            // https://leetcode.com/problems/number-of-recent-calls/description/

            private int _count = 0;
            private Stack<int> pingTimes = new Stack<int>();
            private Stack<int> temp = new Stack<int>();
            private int result = 0;
            public RecentCounter()
            {
                _count = 0;
            }

            public int Ping(int t)
            {
                pingTimes.Push(t);
                int pre = t;
                Console.WriteLine(pre);
                while (pingTimes.Count > 0 && pingTimes.Peek() >= t - 3000)
                {
                    temp.Push(pingTimes.Pop());
                    _count++;
                }
                result = _count;
                _count = 0;
                while (temp.Count > 0)
                {
                    pingTimes.Push(temp.Pop());
                }
                return result;
            }
        }

        /**
         * Your RecentCounter object will be instantiated and called as such:
         * RecentCounter obj = new RecentCounter();
         * int param_1 = obj.Ping(t);
         */
    }
}
