using LeetCode.Common;
using System.Globalization;

namespace LeetCode.Easy
{
    public class MergeTwoSortedLists
    {
        //https://leetcode.com/problems/merge-two-sorted-lists/description/

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode sorted = new ListNode();

            if(ValidarSeEstaNull(list1, list2, out sorted))
            {
                return sorted;
            }

            if(list1.val <= list2.val)
            {
                sorted.val = list1.val;
                list1 = list1.next;
            }
            else
            {
                sorted.val = list2.val;
                list2 = list2.next;
            }

            sorted.next = MergeTwoLists(list1, list2);

            return sorted;
        }

        private static bool ValidarSeEstaNull(ListNode list1, ListNode list2, out ListNode list)
        {
            bool list1IsNull = list1 == null;
            bool list2IsNull = list2 == null;

            if (list1IsNull && list2IsNull)
            {
                list = null;
                return true;
            }

            if (!list1IsNull && list2IsNull)
            {
                list = list1;
                return true;
            }

            if (list1IsNull && !list2IsNull)
            {
                list = list2;
                return true;
            }

            list = new();
            return false;
        }
    }
}
