namespace LeetCode
{
    public class BalancedBinaryTree
    {
        int TotalEsq = 0;
        int TotalDir = 0;

        int inddir = 0;
        int indesq = 0;

        public bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;

            int subdir = 0;
            int subesq = 0;

            int subindicetotal = 0;

            if (root.right != null)
            {
                VerificaTree(root.right, ref TotalDir, ref subdir, ref subesq, 1, 1, 1, ref subindicetotal, true);

                if (!EstaEquilibrado(inddir, indesq)) return false;
                if (!EstaEquilibrado(subdir, subesq)) return false;
            }

            subdir = 0;
            subesq = 0;

            subindicetotal = 0;

            if (root.left != null)
            {
                VerificaTree(root.left, ref TotalEsq, ref subdir, ref subesq, 1, 1, 1, ref subindicetotal, true);

                if (!EstaEquilibrado(inddir, indesq)) return false;
                if (!EstaEquilibrado(subdir, subesq)) return false;
            }

            return EstaEquilibrado(TotalEsq, TotalDir);
        }

        private void VerificaTree(TreeNode Node, ref int Total, ref int SubTotalDir, ref int SubTotalEsq, int Indice, int IndiceEsq, int IndiceDir, ref int SubIndice, bool primeiro = false)
        {
            if(Node.right != null)
            {
                VerificaTree(Node.right, ref Total, ref SubTotalDir, ref SubTotalEsq, Indice + 1, IndiceEsq, IndiceDir + 1, ref SubIndice);
            }

            if (primeiro)
            {
                inddir = SubIndice;
                SubIndice = 0;
            }

            if(Node.left != null)
            {
                VerificaTree(Node.left, ref Total, ref SubTotalDir, ref SubTotalEsq, Indice + 1, IndiceEsq + 1, IndiceDir, ref SubIndice);
            }

            if (primeiro)
            {
                indesq = SubIndice;
            }

            if (Indice > Total)
            {
                Total = Indice;
            }

            if(IndiceDir > SubTotalDir)
            {
                SubTotalDir = IndiceDir;
            }

            if (IndiceEsq > SubTotalEsq)
            {
                SubTotalEsq = IndiceEsq;
            }

            if(inddir < IndiceDir)
            {
                inddir = IndiceDir;
            }

            if (inddir < IndiceEsq)
            {
                inddir = IndiceEsq;
            }

            if (indesq < IndiceDir)
            {
                indesq = IndiceDir;
            }

            if (indesq < IndiceEsq)
            {
                indesq = IndiceEsq;
            }
        }

        private bool EstaEquilibrado(int Val1, int Val2)
        {
            if (Val1 == Val2)
            {
                return true;
            }
            else if (Math.Abs(Val1 - Val2) == 1)
            {
                return true;
            }

            return false;
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
