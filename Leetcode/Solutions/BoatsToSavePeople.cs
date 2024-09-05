namespace Leetcode.Solutions
{
    internal class BoatsToSavePeople
    {
        public int NumRescueBoats(int[] people, int limit)
        {
            Array.Sort(people);
            int left = 0, right = people.Length - 1, count = 0, sum = 0, nop = 0;

            while (left <= right && right >= 0)
            {
                if (nop >= 2 && sum <= limit)
                {

                    sum = 0;
                    count++;
                    nop = 0;
                }
                if (sum + people[right] <= limit)
                {
                    sum += people[right];
                    nop++;
                    right--;
                }
                else if (sum + people[left] <= limit)
                {
                    sum += people[left];
                    left++;
                    nop++;
                }
                else
                {
                    sum = 0;
                    count++;
                    nop = 0;
                }
                if (sum == limit)
                {
                    sum = 0;
                    count++;
                    nop = 0;
                }
            }
            if (sum <= limit && sum != 0)
            {
                sum = 0;
                count++;
            }
            return count;
        }
    }
}
