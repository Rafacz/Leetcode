namespace LC.test.ProblemsTests
{
	public class RotateArray
	{

		[Fact]
		public void RotateArray_ShouldRotateArrayCorrectly1()
		{
			int k = 3;
			int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };
			int[] expected = new int[] { 5, 6, 7, 1, 2, 3, 4 };

			LC.Problems.RotateArray.Rotate(nums, k);

			Assert.Equal(nums, expected);
		}

		[Fact]
		public void RotateArray_ShouldRotateArrayCorrectly2()
		{
			int k = 2;
			int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };
			int[] expected = new int[] { 6, 7, 1, 2, 3, 4, 5 };

			LC.Problems.RotateArray.Rotate(nums, k);

			Assert.Equal(nums, expected);
		}

		[Fact]
		public void RotateArray_ShouldRotateArrayCorrectly3()
		{
			int k = 2;
			int[] nums = new int[] { -1, -100, 3, 99 };
			int[] expected = new int[] { 3, 99, -1, -100 };

			LC.Problems.RotateArray.Rotate(nums, k);

			Assert.Equal(nums, expected);
		}
	}

}
