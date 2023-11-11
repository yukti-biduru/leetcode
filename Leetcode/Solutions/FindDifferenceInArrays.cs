using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    public class FindDifferenceInArrays
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            List<int> result = nums1.ToList().Except(nums2.ToList()).ToList();
            List<int> result1 = nums2.ToList().Except(nums1.ToList()).ToList();
            IList<IList<int>> return_result = new List<IList<int>>
            {
                result,
                result1
            };
            return return_result;
        }

        public IList<IList<int>> GetElementsOnlyInFirstList(int[] first, int[] second)
        {
            List<int> first1 = new List<int>();
            List<int> second1 = new List<int>();
            foreach (int i in first)
            {
                if (!second.Contains(i))
                {
                    first1.Add(i);
                }
            }
            foreach (int i in second)
            {
                if (!first.Contains(i))
                {
                    second1.Add(i);
                }
            }
            IList<IList<int>> return_result = new List<IList<int>>
            {
                first1.Distinct().ToList(),
                second1.Distinct().ToList()
            };
            return return_result;
        }
    }

}
