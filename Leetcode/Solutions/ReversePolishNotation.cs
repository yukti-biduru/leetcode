using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class ReversePolishNotation
    {
        public int EvalRPN1(string[] tokens)
        {
            Stack<string> stk = new(tokens.Length);
            //tokens = tokens.Reverse().ToArray();
            string[] ops = { "*", "/", "+", "-" };
            int current = 0;
            string ans, operand;
            for (int i = 0; i < tokens.Length; i++)
            {
                if (ops.Contains(tokens[i]))
                {
                    operand = tokens[i];
                    ans = stk.Pop();
                    //if (current == 0)
                    current = Convert.ToInt32(stk.Pop());
                    DataTable dt = new DataTable();
                    string exp = current + operand + ans;
                    Console.WriteLine(exp);
                    current = Convert.ToInt32(dt.Compute(exp, ""));
                    stk.Push(current.ToString());
                }
                else
                {
                    stk.Push(tokens[i]);
                }
            }

            return current;
        }

        public int EvalRPN(string[] tokens)
        {
            Stack<int> stk = new(tokens.Length);
            string[] ops = { "*", "/", "+", "-" };
            foreach (string element in tokens)
            {
                if (!ops.Contains(element))
                {
                    stk.Push(Convert.ToInt32(element));
                }
                else
                {
                    int num1 = stk.Pop();
                    int num2 = stk.Pop();
                    if (element == "*")
                        stk.Push(num2 * num1);
                    if (element == "/")
                        stk.Push(num2 / num1);
                    if (element == "+")
                        stk.Push(num2 + num1);
                    if (element == "-")
                        stk.Push(num2 - num1);
                }
            }
            return stk.Pop();
        }


    }
}
