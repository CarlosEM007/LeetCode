namespace LeetCode.Easy
{
    public class RomanToInteger_
    {
        // https://leetcode.com/problems/roman-to-integer/

        public int RomanToInt(string s)
        {
            int resultado = 0;

            Dictionary<string, int> dicRomans = new Dictionary<string, int>
        {
            {"I", 1},
            {"IV", 4},
            {"V", 5},
            {"IX", 9},
            {"X", 10},
            {"XL", 40},
            {"L", 50},
            {"XC", 90},
            {"C", 100},
            {"CD", 400},
            {"D", 500},
            {"CM", 900},
            {"M", 1000}
        };

            for (int i = 0; i < s.Length; i++)
            {
                try
                {
                    resultado += dicRomans[$"{s[i].ToString()}{s[i + 1].ToString()}"];
                    i++;
                }
                catch
                {
                    resultado += dicRomans[s[i].ToString()];
                }
            }

            return resultado;
        }
    }
}
