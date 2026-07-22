using LeetCode.Medium;
using LeetCode._1___Easy;
using LeetCode.Common;

namespace LeetCode
{
    public class LeetCode()
    {
        public static void Main(string[] args)
        {
            ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

            ListNode resultado = MergeTwoSortedLists.MergeTwoLists(list1, list2);

            Console.WriteLine(resultado);

            // Console.WriteLine("[{0}]", string.Join(", ", ConcatenationOfArray.GetConcatenation([1, 3, 2, 1])));
            // Console.WriteLine("[{0}]", string.Join(", ", ShuffleTheArray.Shuffle([2, 5, 1, 3, 4, 7], 3)));
            // Console.WriteLine(MaxConsecutiveOnes.FindMaxConsecutiveOnes([1, 1, 0, 1, 1, 1]));
            // Console.WriteLine(JumpGame.CanJump([5, 9, 3, 2, 1, 0, 2, 3, 3, 1, 0, 0]));

            // Console.WriteLine("[{0}]", string.Join(", ", TransformedArray.ConstructTransformedArray([-10])));
            // Console.WriteLine("[{0}]", string.Join(", ", TransformedArray.ConstructTransformedArray([-10, -10])));

            // Console.WriteLine(TrionicArray.IsTrionic([1, 3, 5, 4, 2, 6]));

            // Console.WriteLine(LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("abcdabc"));

            // Console.WriteLine(MedianOfTwoSortedArrays.FindMedianSortedArrays([1, 2], [3, 4]));

            // Console.WriteLine(StringToIntegerAtoi.MyAtoi(" b11228552307"));
        }
    }
}

    
