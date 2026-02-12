using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode.Medium
{
    public class CopyListWithRandomPointer
    {
        // https://leetcode.com/problems/copy-list-with-random-pointer/description/

        public Node CopyRandomList(Node head)
        {
            try
            {
                List<Node> lstNodes = new List<Node>();
                List<Node> lstNodeHead = new List<Node>();

                Node Auxiliar = head;

                while (true)
                {
                    Node node = new Node(Auxiliar.val);
                    lstNodes.Add(node);

                    Node nodeAuxiliar = Auxiliar;
                    lstNodeHead.Add(nodeAuxiliar);

                    if (Auxiliar.next != null)
                    {
                        Auxiliar = Auxiliar.next;
                    }
                    else
                    {
                        break;
                    }
                }

                for (int i = 0; i < lstNodeHead.Count; i++)
                {
                    if (i + 1 != lstNodeHead.Count)
                    {
                        lstNodes[i].next = lstNodes[i + 1];
                    }

                    for (int j = 0; j < lstNodeHead.Count; j++)
                    {
                        if (lstNodeHead[i].random != null)
                        {
                            if (lstNodeHead[i].random.Equals(lstNodeHead[j]))
                            {
                                lstNodes[i].random = lstNodes[j];
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                return lstNodes[0];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public class Node
        {
            public int val;
            public Node next;
            public Node random;

            public Node(int _val)
            {
                val = _val;
                next = null;
                random = null;
            }
        }
    }
}
