using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    // https://leetcode.com/problems/longest-common-prefix/description/

    public class LongestCommonPrefix_
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string strFinal = "";

            string menorPalavra = MenorPalavra(strs);

            if (menorPalavra == "")
            {
                return menorPalavra;
            }

            int index = 0;

            for (int i = 0; i < menorPalavra.Length; i++)
            {
                string[] charsLetras = new string[strs.Length];

                for (int j = 0; j < charsLetras.Length; j++)
                {
                    charsLetras[j] = strs[j][i].ToString();
                }

                if (ValidaPalavras(charsLetras, menorPalavra, index))
                {
                    strFinal += charsLetras[0];
                }
                else
                {
                    return strFinal;
                }

                index++;
            }

            return strFinal;
        }

        public static bool ValidaPalavras(string[] chars, string MenorPalavra, int x)
        {
            for (int i = 0; i < chars.Length; i++)
            {
                if (MenorPalavra[x].ToString() != chars[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static string MenorPalavra(string[] arrays)
        {
            string menorPalavra = arrays[0];

            for (int i = 0; i < arrays.Length; i++)
            {
                if (arrays[i].Length < menorPalavra.Length)
                {
                    menorPalavra = arrays[i];
                }
            }

            return menorPalavra;
        }
    }
}
