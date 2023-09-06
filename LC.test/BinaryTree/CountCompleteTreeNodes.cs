using LC.BinaryTree;

namespace LC.test.BinaryTree
{
	public class CountCompleteTreeNodes
	{
		[Fact]
		public void Example1()
		{
			// Arrange
			TreeNode root = new TreeNode(
				1,
				new TreeNode(2, new TreeNode(4), new TreeNode(5)),
				new TreeNode(3, new TreeNode(6))
			);
			int expected = 6;

			// Act
			int result = LC.BinaryTree.CountCompleteTreeNodes.CountNodes(root);

			// Assert
			Assert.Equal(expected, result);
		}

		[Fact]
		public void Example2()
		{
			// Arrange
			TreeNode root = null;
			int expected = 0;

			// Act
			int result = LC.BinaryTree.CountCompleteTreeNodes.CountNodes(root);

			// Assert
			Assert.Equal(expected, result);
		}

		[Fact]
		public void Example3()
		{
			// Arrange
			TreeNode root = new TreeNode(1);
			int expected = 1;

			// Act
			int result = LC.BinaryTree.CountCompleteTreeNodes.CountNodes(root);

			// Assert
			Assert.Equal(expected, result);
		}
	}
}
