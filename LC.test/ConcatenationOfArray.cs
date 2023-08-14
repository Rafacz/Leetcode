namespace LC.test
{
	public class ConcatenationOfArray
	{
		[Fact]
		public void ConcatenationOfArray1()
		{
			// Arrange
			int[] nums = { 1, 2, 1 };
			int[] expected = { 1, 2, 1, 1, 2, 1 };

			// Act
			int[] actual = LC.ConcatenationOfArray.GetConcatenation(nums);

			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void ConcatenationOfArray2()
		{
			// Arrange
			int[] nums = { 1, 3, 2, 1 };
			int[] expected = { 1, 3, 2, 1, 1, 3, 2, 1 };

			// Act
			int[] actual = LC.ConcatenationOfArray.GetConcatenation(nums);

			// Assert
			Assert.Equal(expected, actual);
		}
	}
}
