using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class NoOfRecentCalls
    {
        private int _count = 0;
        private Stack<int> pingTimes = new Stack<int>();
        private Stack<int> temp = new Stack<int>();
        private int result = 0;
        public NoOfRecentCalls()
        {
            _count = 0; 
        }

        public int Ping(int t)
        {
            pingTimes.Push(t);
            int pre = t;
            while(pingTimes.Count > 0 && pre >= t-3000)
            {
                temp.Push(pingTimes.Pop());
                _count++;
            }
            result = _count;
            _count = 0;
            while(temp.Count > 0)
            {
                pingTimes.Push(temp.Pop());
            }
            return result;
        }
    }
}
