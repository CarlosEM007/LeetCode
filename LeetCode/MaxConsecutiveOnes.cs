using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class MaxConsecutiveOnes
    {
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int MelhorSequencia = 0;
            int Contador = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    Contador++;

                    if (i == nums.Length - 1 && Contador > MelhorSequencia)
                    {
                        MelhorSequencia = Contador;
                    }
                }
                else
                {
                    if(Contador > MelhorSequencia)
                    {
                        MelhorSequencia = Contador;
                    }

                    Contador = 0;
                }
            }

            return MelhorSequencia;
        }
    }
}
