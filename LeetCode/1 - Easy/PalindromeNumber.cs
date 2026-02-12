using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    // https://leetcode.com/problems/palindrome-number/description/

    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            string strNormal = x.ToString();

            for (int i = 0; i <= strNormal.Length / 2; i++)
            {
                if (x.ToString()[i] != strNormal[strNormal.Length - (i + 1)])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
