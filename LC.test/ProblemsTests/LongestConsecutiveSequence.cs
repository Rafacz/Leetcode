namespace LC.test.ProblemsTests
{
	public class LongestConsecutiveSequence
	{
		[Fact]
		public void TestExample1()
		{
			int[] nums = { 100, 4, 200, 1, 3, 2 };
			int expected = 4;

			int result = Problems.LongestConsecutiveSequence.LongestConsecutive(nums);

			Assert.Equal(expected, result);
		}

		[Fact]
		public void TestExample2()
		{
			int[] nums = { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };
			int expected = 9;

			int result = Problems.LongestConsecutiveSequence.LongestConsecutive(nums);

			Assert.Equal(expected, result);
		}

		[Fact]
		public void TestExample3()
		{
			int[] nums = { 9, 1, -3, 2, 4, 8, 3, -1, 6, -2, -4, 7 };
			int expected = 4;

			int result = Problems.LongestConsecutiveSequence.LongestConsecutive(nums);

			Assert.Equal(expected, result);
		}
	}
}
