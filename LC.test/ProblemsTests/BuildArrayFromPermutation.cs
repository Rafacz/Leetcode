namespace LC.test.ProblemsTests
{
	public class BuildArrayFromPermutation
	{
		[Fact]
		public void BuildArrayFromPermutation1()
		{
			// Arrange
			int[] nums = { 0, 2, 1, 5, 3, 4 };
			int[] expected = { 0, 1, 2, 4, 5, 3 };

			// Act
			int[] actual = LC.Problems.BuildArrayFromPermutation.BuildArray(nums);

			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void BuildArrayFromPermutation2()
		{
			// Arrange
			int[] nums = { 5, 0, 1, 2, 3, 4 };
			int[] expected = { 4, 5, 0, 1, 2, 3 };

			// Act
			int[] actual = LC.Problems.BuildArrayFromPermutation.BuildArray(nums);

			// Assert
			Assert.Equal(expected, actual);
		}
	}
}
