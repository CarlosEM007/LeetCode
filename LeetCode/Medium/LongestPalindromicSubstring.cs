namespace LeetCode.Medium
{
    public static class LongestPalindromicSubstring
    {
        // https://leetcode.com/problems/longest-palindromic-substring/description/

        public static string LongestPalindrome(string s)
        {
            string bigger = s[0].ToString();
            string palindrome = "";

            int i = 0;

            int x = 0;
            int y = 0;

            do
            {
                x = i;
                y = i + 1;

                palindrome = TakePalindrome(x, y, s);
                bigger = PalindromeBigger(palindrome, bigger);

                x = i - 1;
                y = i + 1;

                palindrome = TakePalindrome(x, y, s);
                bigger = PalindromeBigger(palindrome, bigger);
                

                i += 1;
            } while (i < s.Length);

            return bigger;
        }

        private static string TakePalindrome(int x, int y, string s)
        {
            if (x > 0 && y + 1 < s.Length)
            {
                if ((s[x] == s[y]) && (s[x - 1] == s[y + 1]))
                {
                    x -= 1;
                    y += 1;
                    return TakePalindrome(x, y, s);
                }
            }

            int length = s.Length - x - (s.Length - (y + 1));

            return x > -1 && y < s.Length ? (s[x] == s[y]) ? GetPalindrome(x, length, s) : "" : "";
        }

        private static string GetPalindrome(int x, int y, string s) => s.Substring(x, y);
        private static string PalindromeBigger(string p, string b) => p.Length > b.Length ? p : b;
    }
}