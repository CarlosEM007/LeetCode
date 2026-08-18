using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    public static class LongestSubstringWithoutRepeatingCharacters
    {
        // https://leetcode.com/problems/longest-substring-without-repeating-characters/

        public static int LengthOfLongestSubstring(string s)
        {
            string retorno = "";

            for(int i = 0; i < s.Length; i++)
            {
                string auxiliar = "";
                for(int x = i; x < s.Length; x++)
                {
                    if (auxiliar.Contains(s[x]))
                    {
                        break;
                    }
                    else
                    {
                        auxiliar += s[x];
                    }
                }

                if(auxiliar.Length > retorno.Length)
                {
                    retorno = auxiliar;
                }
            }

            return retorno.Length;
        }
    }
}
