using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class TransformedArray
    {
        public static int[] ConstructTransformedArray(int[] nums)
        {
            int[] Retorno = new int[nums.Length];
            int posicao = 0;
            int tamanho = nums.Length - 1;

            for (int i = 0; i < nums.Length; i++)
            {
                posicao = i;

                if (nums[i] > 0)
                {
                    for (int x = 0; x < nums[i]; x++)
                    {
                        posicao++;
                        if (posicao > tamanho) posicao = 0;
                    }
                }
                else if (nums[i] < 0)
                {
                    for (int x = 0; x < nums[i] * -1; x++)
                    {
                        posicao--;
                        if (posicao < 0) posicao = tamanho;
                    }
                }
                else
                {
                    Retorno[i] = nums[0];
                }

                Retorno[i] = nums[posicao];
            }

            return Retorno;
        }
    }
}
/*
i + nums[i] 
    (0 + 1) = 1 (2)
    (1 + 2) = 3 (3)
    (6 - 5) - 1 = 0 (1)
    (7 - 5) - 1 = 1 (2)
    (10 - 5) - 1 = 4 (5)    
1 2 3 3 5

2 3 1 2 5

    (0 + 1) = 1           (-3)
    4 + ((1 - 3) + 1) = 3 (-4)
    4 + ((2 - 3) + 1) = 4 (-5)
    4 + ((3 - 4) + 1) = 4 (-5)
    4 + ((4 - 5) + 1) = 4 (-5)
1 -3 -3 -4 -5

-3 -4 -5 -5 -5
*/