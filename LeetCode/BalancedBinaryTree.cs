namespace LeetCode
{
    public class BalancedBinaryTree
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;

            int AlturaEsquerda = EstaEquilibrado(root.left);
            int AlturaDireita = EstaEquilibrado(root.right);

            if(AlturaEsquerda == -1 || AlturaDireita == -1 || Math.Abs(AlturaEsquerda - AlturaDireita) > 1)
            {
                return false;
            }

            return true;
        }

        private int EstaEquilibrado(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int AlturaEsquerda = EstaEquilibrado(root.left);
            int AlturaDireita = EstaEquilibrado(root.right);

            if (AlturaEsquerda == -1 || AlturaDireita == -1 || Math.Abs(AlturaEsquerda - AlturaDireita) > 1)
            {
                return -1;
            }
            return Math.Max(AlturaEsquerda + 1, AlturaDireita + 1);
        }
    }


    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

}
