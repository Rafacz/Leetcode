namespace LC.BinaryTree
{
	public static class MaximumDepthBinaryTree
	{
		public static int MaxDepth(TreeNode root)
		{
			if (root == null) { return 0; }
			int depth = default;
			int max = default;

			var stack = new Stack<(TreeNode, int)>();
			stack.Push((root, depth));

			while (stack.Count > 0)
			{
				var node = stack.Pop();
				depth = node.Item2 + 1;
				if (node.Item1.right != null) stack.Push((node.Item1.right, depth));
				if (node.Item1.left != null) stack.Push((node.Item1.left, depth));

				if (depth > max) max = depth;
			}

			return max;
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