using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public static class IndiceFirstOccurrence
    {
        // https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/submissions/2111578075/
        // 0 ms

        public static int StrStr(string haystack, string needle)
        {
            if (!haystack.Contains(needle)) return -1;

            int i = 0;

            do
            {
                if(needle == haystack.Substring(i, needle.Length))
                {
                    return i;
                }
                else
                {
                    i += 1;
                }
            } while (i < haystack.Length);

            return i;
        }
    }
}
