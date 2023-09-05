namespace LC.BinaryTree
{
	//104. Maximum Depth of Binary Tree
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
}