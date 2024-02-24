using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class BitwiseANDofNumbers
    {
        public int RangeBitwiseAnd(int left, int right)
        {
            var count = 0;

            while (left != right)
            {
                count++;
                Console.WriteLine(count);
                left = left >> 1;
                Console.WriteLine(left);
                right = right >> 1;
                Console.WriteLine(right);
            }

            return left << count;
        }
    }
}
