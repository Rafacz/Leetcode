namespace LC.test.ProblemsTests
{
	public class ContainerWithMostWater
	{
		[Fact]
		public void MaxArea_Example1_ReturnsExpectedResult()
		{
			int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
			int expected = 49;
			var actual = LC.Problems.ContainerWithMostWater.MaxArea(height);

			Assert.Equal(expected, actual);
		}

		[Fact]
		public void MaxArea_Example2_ReturnsExpectedResult()
		{
			int[] height = { 1, 1 };
			int expected = 1;
			var actual = LC.Problems.ContainerWithMostWater.MaxArea(height);

			Assert.Equal(expected, actual);
		}

		[Fact]
		public void MaxArea_Example3_ReturnsExpectedResult()
		{
			int[] height = { 1, 2, 4, 3 };
			int expected = 4;
			var actual = LC.Problems.ContainerWithMostWater.MaxArea(height);

			Assert.Equal(expected, actual);
		}
	}
}
