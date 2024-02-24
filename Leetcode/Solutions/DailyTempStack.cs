using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class DailyTempStack
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            Stack<int> stk = new Stack<int>();
            int min = int.MaxValue;
            int index = 0;
            for (int i = 0; i < temperatures.Length; i++)
            {
                min = temperatures[i];
                for (int j = i + 1; j < temperatures.Length; j++)
                {
                    if (temperatures[j] > temperatures[i])
                    {
                        { index = j; break; }
                    }
                }
                if (index - i < 0)
                {
                    stk.Push(0);
                }
                else
                    stk.Push(index - i);
            }
            int[] result = stk.ToArray();
            result = result.Reverse().ToArray();
            return result;
        }

    }
}
