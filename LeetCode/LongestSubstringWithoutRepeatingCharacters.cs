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
            StringBuilder retorno = new();

            for(int i = 0; i < s.Length; i++)
            {
                StringBuilder auxiliar = new();
                for(int x = i; x < s.Length; x++)
                {
                    if (auxiliar.ToString().Contains(s[x]))
                    {
                        break;
                    }
                    else
                    {
                        auxiliar.Append(s[x]);
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
