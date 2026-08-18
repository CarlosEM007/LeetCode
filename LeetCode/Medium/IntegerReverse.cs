using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    public static class IntegerReverse
    {
        public static int Reverse(int x)
        {
            string result = x < 0 ? "-" : "";
            string number = x < 0 ? ((long)x * -1).ToString() : x.ToString();

            for (int i = number.Length - 1; i >= 0; i--)
            {
                result += number[i];
            }

            long resultLong = long.Parse(result);

            if(resultLong > int.MaxValue || resultLong < int.MinValue)
                return 0;

            return Convert.ToInt32(resultLong);
        }
    }
}
