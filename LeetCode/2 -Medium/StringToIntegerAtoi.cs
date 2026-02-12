namespace LeetCode.Medium
{
    public class StringToIntegerAtoi
    {
        // https://leetcode.com/problems/string-to-integer-atoi/description/

        public int MyAtoi(string s)
        {
            string strInteiro = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(s))
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s[i].ToString() == " " && string.IsNullOrEmpty(strInteiro))
                        {
                            s = s.Remove(i, 1);
                            i--;
                        }
                        else if ((s[i].ToString() == "-" || s[i].ToString() == "+") && i == 0)
                        {
                            strInteiro += s[i].ToString();
                        }
                        else if (int.TryParse(s[i].ToString(), out int inteiro))
                        {
                            strInteiro += s[i].ToString();
                        }
                        else
                        {
                            if (!int.TryParse(strInteiro, out int result))
                            {
                                if (Convert.ToInt64(strInteiro) > int.MaxValue || Convert.ToInt64(strInteiro) < int.MinValue)
                                {
                                    throw new OverflowException();
                                }

                                strInteiro = "0";
                            }

                            break;
                        }
                    }
                }
                else
                {
                    strInteiro = "0";
                }

                Convert.ToInt32(strInteiro);
            }
            catch (OverflowException)
            {
                if (s.StartsWith("-"))
                {
                    strInteiro = int.MinValue.ToString();
                }
                else
                {
                    strInteiro = int.MaxValue.ToString();
                }
            }
            catch (Exception)
            {
                strInteiro = "0";
            }

            return Convert.ToInt32(strInteiro);
        }
    }
}
