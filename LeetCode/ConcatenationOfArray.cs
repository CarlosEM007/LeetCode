using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class ConcatenationOfArray
    {
        public static int[] GetConcatenation(int[] nums)
        {
            int[] retorno = new int[(nums.Length) * 2];
            int auxiliar = 0;

            for(int i = 0; i < 2; i++)
            {
                for(int x = 0; x < nums.Length; x++)
                {
                    retorno[auxiliar] = nums[x];
                    auxiliar++;
                }
            }

            return retorno;
        }
    }
}
