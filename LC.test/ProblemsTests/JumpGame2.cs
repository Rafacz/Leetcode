namespace LC.test.ProblemsTests
{
	public class JumpGame2
	{
		[Fact]
		public void Example1()
		{
			// Arrange
			int[] nums = { 2, 3, 1, 1, 4 };
			int expected = 2;

			// Act
			int result = LC.Problems.JumpGame2.Jump(nums);

			// Assert
			Assert.Equal(expected, result);
		}

		[Fact]
		public void Example2()
		{
			// Arrange
			var jumpGame = new JumpGame2();
			int[] nums = { 2, 3, 0, 1, 4 };
			int expected = 2;

			// Act
			int result = LC.Problems.JumpGame2.Jump(nums);

			// Assert
			Assert.Equal(expected, result);
		}
	}
}
