using LC.BinaryTree;

namespace LC.test.BinaryTree
{
	public class AverageLevels
	{

		[Fact]
		public void Test1()
		{
			// Arrange
			TreeNode root = new TreeNode(3);
			root.left = new TreeNode(9);
			root.right = new TreeNode(20);
			root.right.left = new TreeNode(15);
			root.right.right = new TreeNode(7);

			// Act
			var result = LC.BinaryTree.AverageLevels.AverageOfLevels(root);

			// Assert
			Assert.Equal(new double[] { 3.0, 14.5, 11.0 }, result);
		}

		[Fact]
		public void Test2()
		{
			// Arrange
			TreeNode root = new TreeNode(3);
			root.left = new TreeNode(9);
			root.right = new TreeNode(20);
			root.right.left = new TreeNode(15);
			root.right.right = new TreeNode(7);

			// Act
			var result = LC.BinaryTree.AverageLevels.AverageOfLevels(root);

			// Assert
			Assert.Equal(new double[] { 3.0, 14.5, 11.0 }, result);
		}
	}
}