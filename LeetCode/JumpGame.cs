using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class JumpGame
    {
        public static bool CanJump(int[] nums)
        {
                for(int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == 0 && i == nums.Length - 1) return true;

                    if (nums[i] == 0)
                    {
                        if(i != 0)
                        {
                            if (ValidarSeContinua(nums[..i]))
                            {
                                continue;
                            }
                        }

                        return false;
                    }

                    if (i == nums.Length - 1) return true;

                    for(int x = nums[i]; x > 0; x--)
                    {
                        if (x + i > nums.Length - 1)
                        {
                            continue;
                        }

                        if (nums[x] == 0 && x + i != nums.Length - 1)
                        {
                            break;
                        }

                        if (x + i == nums.Length - 1)
                        {
                            return true;
                        }

                        break;
                    }
                }

                return false;
        }

        private static bool ValidarSeContinua(int[] ValoresAnteriores)
        {
            int auxiliar = 1;

            for(int i = ValoresAnteriores.Length - 1; i >= 0; i--)
            {
                if (ValoresAnteriores[i] > auxiliar)
                {
                    return true;
                }

                auxiliar++;
            }

            return false;
        }
    }
}
