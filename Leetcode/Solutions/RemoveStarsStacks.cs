using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class RemoveStarsStacks
    {
        public string RemoveStars(string s)
        {
            Stack<char> str = new(s.Length);
            foreach (char c in s)
            {
                if (c == '*')
                {
                    str.Pop();
                }
                else
                {
                    str.Push(c);
                }
            }
            char[] arr = str.ToArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        public string RemoveStars1(string s)
        {
            List<char> str = new List<char>();
            str = s.ToList();
            //int index;
            for (int i = 0; i < str.Count; i++)
            {
                if (str.ElementAt(i) == '*')
                {
                    str.RemoveRange(i - 1, 2);
                    i = i - 2;
                }
                //Console.WriteLine(s);
            }
            //while (str.Contains('*'))
            //{
            //    index = str.FindIndex(i => i == '*');
            //    str.RemoveAt(index);
            //    str.RemoveAt(index - 1);
            //}
            return String.Join("", str);
        }

    }
}
