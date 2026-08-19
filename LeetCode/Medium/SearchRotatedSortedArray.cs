namespace LeetCode.Medium
{
    public static class SearchRotatedSortedArray
    {
        // https://leetcode.com/problems/search-in-rotated-sorted-array/submissions/2112925465/

        public static int Search(int[] nums, int target)
        {
            int inicio = 0;
            int final = nums.Length - 1;

            while(inicio <= final)
            {
                int meio = (final + inicio) / 2;

                if (nums[meio] == target)
                {
                    return meio;
                }
                else if(target <= nums[final])
                {
                    if (target < nums[meio] && nums[meio] < nums[final])
                    {
                        final = meio;
                    }
                    else
                    {
                        inicio = meio + 1;
                    }
                }
                else
                {
                    if(target < nums[meio] || nums[meio] < nums[final])
                    {
                        final = meio - 1;
                    }
                    else
                    {
                        inicio = meio + 1;
                    }
                }
            }

            return -1;
        }
    }
}