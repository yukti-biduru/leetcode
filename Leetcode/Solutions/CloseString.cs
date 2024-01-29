using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class CloseString
    {

        public bool CloseStrings(string word1, string word2)
        {
            Dictionary<char, int> word1set = new Dictionary<char, int>();
            Dictionary<char, int> word2set = new Dictionary<char, int>();
            if (word1.Length != word2.Length)
            {
                return false;
            }
            foreach (var item in word1)
            {
                if (word1set.ContainsKey(item))
                {
                    word1set[item]++;
                }
                else
                {
                    word1set.Add(item, 1);
                }
            }
            foreach (var item in word2)
            {
                if (word2set.ContainsKey(item))
                {
                    word2set[item]++;
                }
                else
                {
                    word2set.Add(item, 1);
                }
            }

            List<char> word1SortedKeys = word1set.Keys.ToList();
            word1SortedKeys.Sort();
            List<char> word2SortedKeys = word2set.Keys.ToList();
            word2SortedKeys.Sort();

            List<int> word1SortedValues = word1set.Values.ToList();
            word1SortedValues.Sort();
            List<int> word2SortedValues = word2set.Values.ToList();
            word2SortedValues.Sort();
            Console.WriteLine(word1SortedKeys.SequenceEqual(word2SortedKeys));
            if (word1SortedKeys.SequenceEqual(word2SortedKeys))
            {
                Console.WriteLine("True");
                if (word1SortedValues.SequenceEqual(word2SortedValues))
                {
                    return true;
                }
                else
                { return false; }
            }
            else
            {
                return false;
            }
        }
    }
}
