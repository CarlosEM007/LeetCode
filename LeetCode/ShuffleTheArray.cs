using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class ShuffleTheArray
    {
        public static int[] Shuffle(int[] nums, int n)
        {
            int[] retorno = new int[nums.Length];

            int[] array1 = nums[..n];
            int[] array2 = nums[n..];

            int auxiliar = 0;

            for(int i = 0; auxiliar < n; i += 2)
            {
                retorno[i] = array1[auxiliar];
                retorno[i + 1] = array2[auxiliar];

                auxiliar++;
            }

            return retorno;
        }
    }
}


