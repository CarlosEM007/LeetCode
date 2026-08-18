using LeetCode.Common;

namespace LeetCode.Medium
{
    public static class SwapNodesInPairs
    {
        // https://leetcode.com/problems/swap-nodes-in-pairs/description/

        public static ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null) return head;

            int val1 = head.val;
            int val2 = head.next.val;

            head.val = val2;
            head.next.val = val1;

            head.next.next = SwapPairs(head.next.next);

            return head;
        }
    }
}
