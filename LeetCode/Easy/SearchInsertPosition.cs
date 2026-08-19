namespace LeetCode.Easy
{
    public static class SearchInsertPosition
    {
        // https://leetcode.com/problems/search-insert-position/submissions/2112607263/

        public static int SearchInsert(int[] nums, int target)
        {
            if (target > nums[nums.Length - 1]) return nums.Length;
            else if (target <= nums[0] || nums.Length == 1) return 0;

            int inicio = 0;
            int fim = nums.Length - 1;

            while (inicio <= fim)
            {
                int indice = ((fim - inicio) / 2) + inicio;

                if (nums[indice] == target)
                {
                    return indice;
                }
                else if (indice > 0 && (nums[indice - 1] < target) && (target < nums[indice]))
                {
                    return indice;
                }
                else if (nums[indice] > target)
                {
                    fim = indice;
                }
                else if (nums[indice] < target)
                {
                    inicio = indice + 1;
                }
            }

            return -1;
        }
    }
}