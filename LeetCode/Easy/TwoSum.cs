using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    // https://leetcode.com/problems/two-sum/description/

    public class TwoSum_
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int x = 1 + i; x < nums.Length; x++)
                {
                    if (nums[i] + nums[x] == target)
                    {
                        return [i, x];
                    }
                }
            }
            return [];
        }
    }
}
