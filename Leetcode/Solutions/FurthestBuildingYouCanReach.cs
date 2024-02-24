using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class FurthestBuildingYouCanReach
    {
        public int FurthestBuilding(int[] heights, int bricks, int ladders)
        {
            // check jumps with bricks  
            int diff, i = 0, n = heights.Length;
            PriorityQueue<int, int> q = new PriorityQueue<int, int>();
            for (i = 1; i < n; i++)
            {
                diff = heights[i - 1] - heights[i];
                if (diff < 0)
                {
                    bricks += diff;
                    //q.Enqueue(diff);
                    
                }

            }
            return 0;
            // add all to a priority queue
            // if all the bricks are used up, use ladder for the largest jump value 
            // add the bricks back to the brick number 
        }
    }
}
