using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class FizzBuzz
    {
        public static void fizzBuzz(int n)
        {
            for( int i=1; i<= n; i++)
            {
                if(i%3 ==0 && i%5 ==0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i%3 ==0 && i%5 !=0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 3 != 0 && i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
