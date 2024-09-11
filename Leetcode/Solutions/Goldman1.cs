namespace Leetcode.Solutions
{
    internal class Goldman1
    {
        public string plusMult(List<int> A)
        {
            int n = A.Count;
            int odd_val = 0;
            int a = 0;
            int b = 0;
            int even_val = 0;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    if (a % 2 == 0)
                    {
                        even_val += A[i];
                        a++;
                    }
                    else
                    {
                        even_val *= A[i];
                        a++;
                    }
                }
                else
                {
                    if (b % 2 == 0)
                    {
                        odd_val += A[i];
                        b++;
                    }
                    else
                    {
                        odd_val *= A[i];
                        b++;
                    }
                }
            }

            even_val = Math.Abs(even_val % 2);
            odd_val = Math.Abs(odd_val % 2);

            if (even_val > odd_val)
            {
                return "EVEN";
            }
            else if (even_val < odd_val)
            {
                return "ODD";
            }
            return "NEUTRAL";
        }
    }


}
