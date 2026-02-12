namespace LeetCode.Easy
{
    public class ValidParentheses
    {
        // https://leetcode.com/problems/valid-parentheses/description/

        public bool IsValid(string s)
        {
            Dictionary<char, char> dicDic = new Dictionary<char, char>()
            {
                {'{', '}' },
                {'[', ']' },
                {'(', ')' },
            };

            string abertosValida = " { ( [ ";

            char[] chars = s.ToCharArray();

            List<char> EmAberto = new List<char>();

            for (int i = 0; i < chars.Length; i++)
            {
                if (abertosValida.Contains(chars[i]))
                {
                    EmAberto.Add(chars[i]);
                }
                else if (i > 0)
                {
                    if (EmAberto.Count > 0)
                    {
                        if (dicDic[EmAberto.Last()] == chars[i])
                        {
                            EmAberto.RemoveAt(EmAberto.Count - 1);
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            if (EmAberto.Count > 0)
            { return false; }

            return true;
        }
    }
}
