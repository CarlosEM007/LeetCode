namespace LeetCode.Medium
{
    public class AddTwoNumber
    {
        // https://leetcode.com/problems/add-two-numbers/description/

        private ListNode AddNewNode(ListNode l1, ListNode l2, bool Sobrou)
        {
            ListNode Node = new();

            if (l1 == null && l2 == null)
            {
                if (Sobrou)
                {
                    Node.val = 1;
                    return Node;
                }

                return null;
            }

            int a = l1 != null ? l1.val : 0;
            int b = l2 != null ? l2.val : 0;


            Node.val = Calcula(a, b, ref Sobrou);
            Node.next = AddNewNode(l1?.next, l2?.next, Sobrou);

            return Node;
        }

        private int Calcula(int a, int b, ref bool Sobrou)
        {
            int c = a + b;

            if (Sobrou)
            {
                c += 1;
                Sobrou = false;
            }

            if (c >= 10)
            {
                Sobrou = true;
                c -= 10;
            }

            return c;
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int a = l1 != null ? l1.val : 0;
            int b = l2 != null ? l2.val : 0;

            bool Sobrou = false;

            ListNode Root = new(Calcula(a, b, ref Sobrou), AddNewNode(l1.next, l2.next, Sobrou));

            return Root;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public override string ToString()
        {
            var values = new List<int>();
            ListNode current = this;

            while (current != null)
            {
                values.Add(current.val);
                current = current.next;
            }

            return "[" + string.Join(",", values) + "]";
        }
    }
}
