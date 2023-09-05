using LC.BinaryTree;

namespace LC.test.BinaryTree
{
	public class MaximumDepthBinaryTree
	{
		[Fact]
		public void TestExample1()
		{
			// Arrange
			TreeNode root = new TreeNode(3);
			root.left = new TreeNode(9);
			root.right = new TreeNode(20);
			root.right.left = new TreeNode(15);
			root.right.right = new TreeNode(7);

			// Act
			int result = LC.BinaryTree.MaximumDepthBinaryTree.MaxDepth(root);

			// Assert
			Assert.Equal(3, result);
		}

		[Fact]
		public void TestExample2()
		{
			// Arrange
			TreeNode root = new TreeNode(1);
			root.right = new TreeNode(2);

			// Act
			int result = LC.BinaryTree.MaximumDepthBinaryTree.MaxDepth(root);

			// Assert
			Assert.Equal(2, result);
		}
	}
}
