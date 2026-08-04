using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._2__Medium
{
    public static class LongestPalindromicSubstring
    {
        //https://leetcode.com/problems/longest-palindromic-substring/description/

        public static string LongestPalindrome(string s)
        {
            string Bigger = "";
            ReadOnlySpan<char> Original = s;

            for(int i = 0; i < s.Length; i++)
            {
                if (Bigger.Length > Original.Length)
                    return Bigger;

                for(int x = 0; x < s.Length - i; x++)
                {
                    ReadOnlySpan<char> Normal = Original.Slice(0, x + 1);
                    ReadOnlySpan<char> Invert = StringInvert(Normal.ToString());

                    bool IsPalindrome = Normal.SequenceEqual(Invert);

                    Bigger = IsPalindrome && (Normal.Length > Bigger.Length) 
                        ? Normal.ToString() 
                        : Bigger; 
                }

                Original = Original.Slice(1);
            }

            return Bigger;
        }

        private static string StringInvert(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}