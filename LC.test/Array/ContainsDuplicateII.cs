namespace LC.test.Array
{
	public class ContainsDuplicateII
	{
		[Fact]
		public void Example1()
		{
			// Arrange
			int[] nums = { 1, 2, 3, 1 };
			int k = 3;

			// Act
			bool result = Arrays.ContainsDuplicateII.ContainsNearbyDuplicate(nums, k);

			// Assert
			Assert.True(result);
		}

		[Fact]
		public void Example2()
		{
			// Arrange
			int[] nums = { 1, 0, 1, 1 };
			int k = 1;

			// Act
			bool result = Arrays.ContainsDuplicateII.ContainsNearbyDuplicate(nums, k);

			// Assert
			Assert.True(result);
		}

		[Fact]
		public void Example3()
		{
			// Arrange
			int[] nums = { 1, 2, 3, 1, 2, 3 };
			int k = 2;

			// Act
			bool result = Arrays.ContainsDuplicateII.ContainsNearbyDuplicate(nums, k);

			// Assert
			Assert.False(result);
		}
	}
}
