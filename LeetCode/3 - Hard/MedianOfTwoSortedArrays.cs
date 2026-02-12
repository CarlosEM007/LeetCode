using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hard
{
    public static class MedianOfTwoSortedArrays
    {
        // https://leetcode.com/problems/median-of-two-sorted-arrays/description/

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            nums1 = nums1.Concat(nums2).Order().ToArray();

            if(nums1.Length % 2 == 0)
            {
                int indice = nums1.Length / 2;
                return (double)(nums1[indice] + nums1[indice - 1]) / 2;
            }
            else
            {
                int indice = nums1.Length / 2;
                return nums1[indice];
            }
        }
    }
}
