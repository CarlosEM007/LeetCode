namespace LeetCode
{
    public class LeetCode()
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("[{0}]", string.Join(", ", ConcatenationOfArray.GetConcatenation([1, 3, 2, 1])));
            // Console.WriteLine("[{0}]", string.Join(", ", ShuffleTheArray.Shuffle([2, 5, 1, 3, 4, 7], 3)));
            // Console.WriteLine(MaxConsecutiveOnes.FindMaxConsecutiveOnes([1, 1, 0, 1, 1, 1]));
            // Console.WriteLine(JumpGame.CanJump([5, 9, 3, 2, 1, 0, 2, 3, 3, 1, 0, 0]));

            // Console.WriteLine("[{0}]", string.Join(", ", TransformedArray.ConstructTransformedArray([-10])));
            // Console.WriteLine("[{0}]", string.Join(", ", TransformedArray.ConstructTransformedArray([-10, -10])));

            //Console.WriteLine(TrionicArray.IsTrionic([1, 3, 5, 4, 2, 6]));

            TestarArvore();
        }

        private static void Recursivo(int valor)
        {
            if (valor == 5) return;

            Recursivo(valor + 1);

            Console.WriteLine($"{valor}");
        }

        private static void TestarArvore()
        {
            TreeNode root = new TreeNode(2);

            // nível 1
            root.left = new TreeNode(1);
            root.right = new TreeNode(3);

            // nível 2
            root.left.left = new TreeNode(0);
            root.left.right = new TreeNode(7);

            root.right.left = new TreeNode(9);
            root.right.right = new TreeNode(1);

            // nível 3
            root.left.left.left = new TreeNode(2);

            root.left.right.left = new TreeNode(1);
            root.left.right.right = new TreeNode(0);

            root.right.right.left = new TreeNode(8);
            root.right.right.right = new TreeNode(8);

            // nível 4
            root.left.right.right.left = new TreeNode(7);

            Console.WriteLine(new BalancedBinaryTree().IsBalanced(root));
        }
    }
}

    
