namespace LC.test.Array
{
	public class TwoSum
	{

		[Fact]
		public void Example1()
		{
			// Arrange
			int[] nums = { 2, 7, 11, 15 };
			int target = 9;
			int[] result = Arrays.TwoSum.TwoSums(nums, target);

			// Act & Assert
			Assert.Equal(new int[] { 0, 1 }, result);
		}

		[Fact]
		public void Example2()
		{
			// Arrange
			int[] nums = { 3, 2, 4 };
			int target = 6;
			int[] result = Arrays.TwoSum.TwoSums(nums, target);

			// Act & Assert
			Assert.Equal(new int[] { 1, 2 }, result);
		}

		[Fact]
		public void Example3()
		{
			// Arrange
			int[] nums = { 3, 3 };
			int target = 6;
			int[] result = Arrays.TwoSum.TwoSums(nums, target);

			// Act & Assert
			Assert.Equal(new int[] { 0, 1 }, result);
		}
	}
}
