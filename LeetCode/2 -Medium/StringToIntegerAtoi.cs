namespace LeetCode.Medium
{
    public class StringToIntegerAtoi
    {
        // https://leetcode.com/problems/string-to-integer-atoi/description/

        public static int MyAtoi(string s)
        {
            if(string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s))
            {
                return 0;
            }

            int inteiro;

            string valor = "";

            if(!int.TryParse(s[0].ToString(), out inteiro))
            {
                if (s[0] != '-' && s[0] != '+' && s[0] != ' ')
                {
                    return 0;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] == '-' || s[i] == '+') && valor == "")
                {
                    valor += s[i];
                    continue;
                }
                else if((s[i] == '-' || s[i] == '+') && valor != "")
                {
                    break;
                }


                if (s[i] == ' ' && valor == "")
                {
                    continue;
                }

                int.TryParse(s[i].ToString(), out inteiro);

                if (inteiro == 0 && s[i] != '0')
                {
                    break;
                }

                valor += s[i];
            }
            
            if(valor == "+" || valor == "-")
            {
                return 0;
            }

            if(!int.TryParse(valor, out int result))
            {
                if(valor == "")
                {
                    return 0;
                }

                if (valor[0] != '-')
                {
                    return int.MaxValue;
                }
                else
                {
                    return int.MinValue;
                }
            }

            return result;
        }


        public int MyAtoi_1(string s)
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
