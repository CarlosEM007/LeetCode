using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._2__Medium
{
    public class ZigzagConversion
    {
        public static string Convert(string s, int numRows)
        {
            // https://leetcode.com/problems/zigzag-conversion/description/

            int i = 0;
            int x = 0;

            bool isSubindo = false;
            string[] strings = new string[numRows];

            do
            {
                strings[x] += s[i];

                if (!isSubindo)
                {
                    if((x + 1) == numRows)
                    {
                        x -= 1;
                        isSubindo = true;
                    }
                    else
                    {
                        x += 1;
                    }
                }
                else
                {
                    if((x - 1) == -1)
                    {
                        x += 1;
                        isSubindo = false;
                    }
                    else
                    {
                        x -= 1;
                    }
                }

                i += 1;
            } while (i < s.Length);

            string retorno = string.Concat(strings);

            return retorno;
        }
    }
}