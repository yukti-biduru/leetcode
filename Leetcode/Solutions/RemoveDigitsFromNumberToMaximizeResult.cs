namespace Leetcode.Solutions
{
    internal class RemoveDigitsFromNumberToMaximizeResult
    {
        public string RemoveDigit(string number, char digit)
        {
            List<int> vals = new List<int>();
            int i = 0;
            string num = "";
            foreach (char c in number)
            {

                if (c == digit)
                {
                    num = number.Remove(i, 1);
                    vals.Add(Convert.ToInt32(num));
                }
                i++;
            }
            return vals.Max().ToString();
        }
    }
}
