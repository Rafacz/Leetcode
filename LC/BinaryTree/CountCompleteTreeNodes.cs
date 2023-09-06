namespace LC.BinaryTree
{
	//222. Count Complete Tree Nodes
	public static class CountCompleteTreeNodes
	{
		public static int CountNodes(TreeNode root)
		{
			if (root == null) { return 0; }
			int count = default;

			var stack = new Stack<TreeNode>();
			stack.Push(root);

			while (stack.Count > 0)
			{
				var node = stack.Pop();
				count++;
				if (node.right != null) stack.Push((node.right));
				if (node.left != null) stack.Push((node.left));
			}

			return count;
		}
	}
}
