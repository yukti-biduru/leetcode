namespace Leetcode.Solutions
{
    internal class AsteroidCollisionStack
    {
        public int[] AsteroidCollision(int[] asteroids)
        {
            Stack<int> stk = new Stack<int>();
            foreach (int ast in asteroids)
            {
                stk.Push(ast);
                while (stk.Count > 1)
                {
                    int num1 = stk.Pop();
                    int num2 = stk.Pop();
                    if (num1 < 0 && num2 > 0)
                    {
                        if (Math.Abs(num1) != Math.Abs(num2))
                            stk.Push(Math.Abs(num1) > Math.Abs(num2) ? num1 : num2);
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
            //loop through values
            foreach (int asteroid in asteroids)
            {
                // add val if nothing in list 
                if (asteroid > 0)
                {
                    stk.Push(asteroid);
                }
                // if something in list 
                else
                {
                    // check if val at top of stack is less than current val
                    // repeat until valid
                    while (stk.Count > 0 && stk.Peek() > 0 && stk.Peek() < Math.Abs(asteroid))
                    {
                        // remove top stack val if so
                        stk.Pop();
                    }


                    // if finished with all values add current to stack
                    if (stk.Count == 0 || stk.Peek() < 0)
                    {
                        stk.Push(asteroid);
                    }
                    // if both current and top stack values are same then dont add anything and remove top stack val
                    else if (stk.Peek() == Math.Abs(asteroid))
                    {
                        stk.Pop();
                    }
                }
            }

            // loop though stack to return result
            int[] result = new int[stk.Count];
            for (int i = stk.Count - 1; i >= 0; i--)
            {
                result[i] = stk.Pop();
            }
            return result;
        }
    }
}