using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class LongestSubstringWithoutRepeatingCharacters
    {
        public static int LengthOfLongestSubstring(string s)
        {
            List<StringBuilder> Strings = new List<StringBuilder>();
            int IndiceAuxiliar = 0;

            for(int i = 0; i < s.Length; i++)
            {
                if(Strings.Count == 0)
                {
                    Strings.Add(new());
                }

                for(int x = i; x < s.Length; x++)
                {
                    if (Strings[IndiceAuxiliar].ToString().Contains(s[x]))
                    {
                        Strings.Add(new());
                        IndiceAuxiliar += 1;

                        break;
                    }
                    else
                    {
                        Strings[IndiceAuxiliar].Append(s[x]);
                    }
                }
            }

            if (!Strings.Any()) return 0;

            return BiggerStringBuilder(Strings);
        }

        private static int BiggerStringBuilder(List<StringBuilder> s)
        {
            int Count = 0;

            for(int i = 0; i < s.Count; i++)
            {
                if (s[i].Length > Count)
                {
                    Count = s[i].Length;
                }
            }

            return Count;
        }
    }
}
