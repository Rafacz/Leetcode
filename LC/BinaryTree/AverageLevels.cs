namespace LC.BinaryTree
{
	//637. Average of Levels in Binary Tree
	public static class AverageLevels
	{
		public static IList<double> AverageOfLevels(TreeNode root)
		{
			var result = new List<double>();

			if (root == null)
				return result;

			var q = new Queue<TreeNode>();

			q.Enqueue(root);

			while (q.Count > 0)
			{
				int count = q.Count;
				double sum = 0;

				for (int i = 0; i < count; i++)
				{
					TreeNode node = q.Dequeue();
					sum += node.val;

					if (node.left != null)
						q.Enqueue(node.left);
					if (node.right != null)
						q.Enqueue(node.right);
				}

				result.Add(sum / count);
			}

			return result;
		}
	}
}
