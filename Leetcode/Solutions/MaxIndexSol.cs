namespace Leetcode.Solutions
{
    internal class MaxIndexSol
    {
        //public int maxIndex(int steps, int badIndex)
        //{

        //    int max_index = 0;

        //    // Calculate maximum possible
        //    // index that can be reached
        //    for (int i = 1; i <= steps; i++)
        //    {
        //        max_index += i;
        //    }

        //    int current_index = max_index,
        //                        step = steps;

        //    while (true)
        //    {

        //        // Check if current index 
        //        // and step both are greater 
        //        // than 0 or not
        //        while (current_index > 0 &&
        //                        steps > 0)
        //        {

        //            // Decrement current_index 
        //            // by step
        //            current_index -= steps;

        //            // Check if current index 
        //            // is equal to B or not
        //            if (current_index == badIndex)
        //            {

        //                // Restore to previous 
        //                // index
        //                current_index += steps;
        //            }

        //            // Decrement step by one
        //            steps--;
        //        }

        //        // If it reaches the 0th index
        //        if (current_index <= 0)
        //        {

        //            // Print result
        //            Console.Write(max_index + " ");
        //            break;
        //        }

        //        // If max index fails to
        //        // reach the 0th index
        //        else
        //        {
        //            steps = step;

        //            // Store max_index - 1 in 
        //            // current index
        //            current_index = max_index - 1;

        //            // Decrement max index
        //            max_index--;

        //            // If current index is 
        //            // equal to B
        //            if (current_index == badIndex)
        //            {

        //                current_index = max_index - 1;

        //                // Decrement current index
        //                max_index--;
        //            }
        //        }
        //    }
        //}


        //public int FindMaxIndex(int steps, int badIndex)
        //{
        //    int maxReach = 0;
        //    int i = 0; // Current index
        //    int j = 1; // Multiplier starting from 1

        //    for (int count = 0; count < steps; count++)
        //    {
        //        int nextIndex = maxReach + j;

        //        // Check if the nextIndex is the bad index
        //        if (nextIndex == badIndex)
        //        {
        //            // Skip this step and try the next
        //            j++;
        //            count--; // Decrement the count to try this step again with a new j
        //            continue;
        //        }

        //        // Update maxReach
        //        maxReach = nextIndex;
        //        j++;
        //    }

        //    return maxReach;
        //}
        //public int maxIndex(int steps, int badIndex)
        //{

        //    int i = 0, j = 1;

        //    int sum = steps * (steps + 1) / 2;

        //    while (j <= steps)
        //    {

        //        i += j;

        //        j++;

        //        if (i == badIndex)
        //        {
        //            return sum - 1;
        //        }
        //    }

        //    return sum;
        //}


        public bool IsNaturalSum(int badIndex)
        {
            double x = (-1 + Math.Sqrt(1 + (8 * badIndex))) / 2;
            bool flag = Math.Ceiling(x) == Math.Floor(x);
            return flag;
        }

        public int maxIndex(int steps, int badIndex)
        {
            int max = (steps * (steps + 1)) / 2;
            bool isReachable = IsNaturalSum(badIndex);
            return isReachable ? max - 1 : max;
        }


    }
}