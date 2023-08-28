namespace LC.test.ProblemsTests
{
	public class Sqrtx
	{
		[Fact]
		public void TestMySqrt_Case1()
		{
			// Arrange
			int input = 4;
			int expected = 2;

			// Act
			int result = LC.Problems.Sqrtx.MySqrt(input);

			// Assert
			Assert.Equal(expected, result);
		}

		[Fact]
		public void TestMySqrt_Case2()
		{
			// Arrange
			int input = 8;
			int expected = 2;

			// Act
			int result = LC.Problems.Sqrtx.MySqrt(input);

			// Assert
			Assert.Equal(expected, result);
		}

		[Fact]
		public void TestMySqrt_Case3()
		{
			// Arrange
			int input = 5;
			int expected = 2;

			// Act
			int result = LC.Problems.Sqrtx.MySqrt(input);

			// Assert
			Assert.Equal(expected, result);
		}

		[Fact]
		public void TestMySqrt_Case4()
		{
			// Arrange
			int input = 2147395600;
			int expected = 46340;

			// Act
			int result = LC.Problems.Sqrtx.MySqrt(input);

			// Assert
			Assert.Equal(expected, result);
		}
	}
}