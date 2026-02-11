namespace LeetCode
{
    public class AddTwoNumber
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            List<int> Valores = new();
            bool PassouDe10 = false;

            do
            {
                int a = l1 != null ? l1.val : 0;
                int b = l2 != null ? l2.val : 0;

                int c = a + b;

                if (PassouDe10)
                {
                    c += 1;
                    PassouDe10 = false;
                }

                if(c >= 10)
                {
                    PassouDe10 = true;
                    c -= 10;
                }

                Valores.Add(c); 

                if (l1?.next == null && l2?.next == null)
                {
                    if (PassouDe10)
                    {
                        Valores.Add(1);
                    }

                    break;
                }

                l1 = l1?.next;
                l2 = l2?.next;

            } while (true);

            ListNode Node = new(-1);

            for(int i = Valores.Count - 1; i >= 0; i--)
            {
                if(i == Valores.Count - 1)
                {
                    Node.val = Valores[i];
                }

                if(i - 1 >= 0)
                {
                    ListNode n = new(Valores[i - 1], Node);
                    Node = n;
                }
            }

            return Node;
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
