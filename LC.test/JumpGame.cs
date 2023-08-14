namespace LC.test
{
	public class JumpGame
	{
		[Fact]
		public void CanJump1()
		{
			// Arrange
			int[] nums = { 2, 3, 1, 1, 4 };
			bool expected = true;

			// Act
			bool actual = LC.JumpGame.CanJump(nums);

			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void CanJump2()
		{
			// Arrange
			int[] nums = { 3, 2, 1, 0, 4 };
			bool expected = false;

			// Act
			bool actual = LC.JumpGame.CanJump(nums);

			// Assert
			Assert.Equal(expected, actual);
		}
	}
}
