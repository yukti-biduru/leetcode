namespace Leetcode.Solutions
{
    internal class CompareVersions
    {
        public int CompareVersion(string version1, string version2)
        {
            List<int> ver1 = new List<int>();
            List<int> ver2 = new List<int>();

            string inter = "";
            version1 += '.';
            version2 += '.';
            foreach (char c in version1)
            {
                if (c != '.')
                {
                    inter += c;
                }
                else
                {
                    ver1.Add(Convert.ToInt32(inter));
                    inter = "";
                }
            }
            foreach (char c in version2)
            {
                if (c != '.')
                {
                    inter += c;
                }
                else
                {
                    ver2.Add(Convert.ToInt32(inter));
                    inter = "";
                }
            }
            int i = 0;
            while (ver1.Count != i && ver2.Count != i)
            {
                if (ver1[i] > ver2[i])
                {
                    return 1;
                }
                else if (ver1[i] < ver2[i])
                {
                    return -1;
                }
                i++;
            }

            while (ver1.Count > i)
            {
                if (ver1[i] > 0)
                {
                    return 1;
                }
                i++;
            }
            while (ver2.Count > i)
            {
                if (ver2[i] > 0)
                {
                    return -1;
                }
                i++;
            }
            return 0;
        }
    }
}
