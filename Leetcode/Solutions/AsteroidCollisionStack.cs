using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class AsteroidCollisionStack
    {
        public int[] AsteroidCollision(int[] asteroids)
        {
            Stack<int> stk = new Stack<int>();
            foreach(int ast in asteroids)
            {
                stk.Push(ast);
                while(stk.Count>1)
                {
                    int num1 = stk.Pop();
                    int num2 = stk.Pop();
                    if(num1<0 && num2>0)
                    {
                        if(Math.Abs(num1)!=Math.Abs(num2))
                            stk.Push(Math.Abs(num1)>Math.Abs(num2)?num1:num2);
                    }
                    else
                    {
                        stk.Push(num2);
                        stk.Push(num1);
                        break;
                    }
                }
            }
            int[] result = stk.ToArray();
            result = result.Reverse().ToArray();
            return result;
        }
        public int[] AsteroidCollision1(int[] asteroids)
        {
            Stack<int> stk = new Stack<int>();
            foreach(int asteroid in asteroids)
            {
                if (asteroid > 0)
                {
                    stk.Push(asteroid);
                }
                else
                {
                    while (stk.Count > 0 && stk.Peek() > 0 && stk.Peek() < Math.Abs(asteroid))
                    {
                        stk.Pop();
                    }

                    if (stk.Count == 0 || stk.Peek() < 0)
                    {
                        stk.Push(asteroid);
                    }
                    else if (stk.Peek() == Math.Abs(asteroid))
                    {
                        stk.Pop();
                    }
                }
            }
            int[] result = new int[stk.Count];
            for(int i=stk.Count-1; i>=0; i--)
            {
                result[i] = stk.Pop();
            }
            return result;
        }
    }
}