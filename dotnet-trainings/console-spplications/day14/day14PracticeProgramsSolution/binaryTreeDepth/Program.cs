namespace binaryTreeDepth
{
    internal class Program
    {
        public async Task<int> FindDepth(TreeNode root)
        {
            return  GetMinDepth(root);
        }

        public int GetMinDepth(TreeNode node)
        {
            if (node == null)
                return 0;
            if (node.left != null && node.right == null)
                return 1 + GetMinDepth(node.left);
            if (node.left == null && node.right != null)
                return 1 + GetMinDepth(node.right);
            int l = 1 + GetMinDepth(node.left);
            int r = 1 + GetMinDepth(node.right);
            if (l <= r)
                return l;
            else
                return r;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
