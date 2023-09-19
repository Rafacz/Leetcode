namespace LC.test.Array
{
	public class ContainsDuplicate
	{
		[Fact]
		public void Example1()
		{
			// Arrange
			int[] nums = { 1, 2, 3, 1 };
			bool expected = true;

			// Act
			bool result = Arrays.ContainsDuplicate.ContainsDuplicates(nums);

			// Assert
			Assert.Equal(expected, result);
		}

		[Fact]
		public void Example2()
		{
			// Arrange
			int[] nums = { 1, 2, 3, 4 };
			bool expected = false;

			// Act
			bool result = Arrays.ContainsDuplicate.ContainsDuplicates(nums);

			// Assert
			Assert.Equal(expected, result);
		}

		[Fact]
		public void Example3()
		{
			// Arrange
			int[] nums = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
			bool expected = true;

			// Act
			bool result = Arrays.ContainsDuplicate.ContainsDuplicates(nums);

			// Assert
			Assert.Equal(expected, result);
		}
	}
}
