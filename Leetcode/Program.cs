// See https://aka.ms/new-console-template for more information
using Leetcode.Solutions;

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = {1, 2, 3};
        int[] arr2 = { 2, 4, 6 };
        FindDifferenceInArrays solution = new FindDifferenceInArrays();
        IList<IList<int>> output = solution.GetElementsOnlyInFirstList(arr, arr2);
    }
}

