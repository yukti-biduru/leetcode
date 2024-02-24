using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class PowerOfTwo
    {
        public bool IsPowerOfTwo(int n)
        {
            return (Math.Log2(n) % 2 == 0);
        }
    }
}
