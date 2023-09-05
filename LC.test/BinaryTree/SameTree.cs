using LC.BinaryTree;

namespace LC.test.BinaryTree
{
	public class SameTree
	{
		[Fact]
		public void TestExample1()
		{
			// Arrange
			TreeNode p = new TreeNode(1);
			p.left = new TreeNode(2);
			p.right = new TreeNode(3);

			TreeNode q = new TreeNode(1);
			q.left = new TreeNode(2);
			q.right = new TreeNode(3);

			// Act
			bool result = LC.BinaryTree.SameTree.IsSameTree(p, q);

			// Assert
			Assert.True(result);
		}

		[Fact]
		public void TestExample2()
		{
			// Arrange
			TreeNode p = new TreeNode(1);
			p.left = new TreeNode(2);

			TreeNode q = new TreeNode(1);
			q.right = new TreeNode(2);

			// Act
			bool result = LC.BinaryTree.SameTree.IsSameTree(p, q);

			// Assert
			Assert.False(result);
		}

		[Fact]
		public void TestExample3()
		{
			// Arrange
			TreeNode p = new TreeNode(1);
			p.left = new TreeNode(2);
			p.right = new TreeNode(1);

			TreeNode q = new TreeNode(1);
			q.left = new TreeNode(1);
			q.right = new TreeNode(2);

			// Act
			bool result = LC.BinaryTree.SameTree.IsSameTree(p, q);

			// Assert
			Assert.False(result);
		}
	}
}
