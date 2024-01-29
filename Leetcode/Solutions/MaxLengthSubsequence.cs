using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class MaxLengthSubsequence
    {
        public int MaxLength(IList<string> arr)
        {
            // Dynamic programming
            // Break the problem into smaller sub problems
            // start with single items
            // build up by adding each of the items following that item in the original array 
            // concatenate the strings  
            // find if unique letter or not  
            // if yes then count length and check max 
            // else go forward 

            // break the array into smaller sequences  
            // iterate over the sequences to find the maximum count of unique concatenations 

            int maxLength = 0;
            return maxLength;
        }

        // concatenate give array, find if it has unique letters, return length if yes, 0 if no 
        public int ConcatenateArray(IList<string> arr)
        {
            string str = String.Concat(arr);
            Console.WriteLine(str);
            return str.Length;
        }

        // create subsequence from the given arrays where the function adds each element from the second list to the first list 
        // one by one and return the list of the new arrays 
        public IList<IList<string>> CreateSubSequence(IList<string> first, IList<string> second)
        {
            IList<IList<string>> subsequences = new List<IList<string>>();
            foreach (string str in second)
            {
                IList<string> temp = first.Append(str).ToList();
                subsequences.Add(temp);
                foreach (var item in temp)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("\n");
            }
            return subsequences;
        }
    }
}
