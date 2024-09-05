namespace Leetcode.Solutions
{
    internal class Subsets
    {
        public IList<IList<int>> Subsets1(int[] nums)
        {
            // return all subsets in any order  
            // https://leetcode.com/problems/subsets/?envType=daily-question&envId=2024-05-21


            IList<IList<int>> result = new List<IList<int>>();
            result.Add(new List<int>());
            int size;
            foreach (int num in nums)
            {
                size = result.Count;
                for (int i = 0; i < size; i++)
                {
                    List<int> newsubset = new List<int>(result[i]);
                    newsubset.Add(num);
                    result.Add(newsubset);
                }
            }
            return result;


        }
    }
}
