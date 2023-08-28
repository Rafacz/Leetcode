namespace LC.test.ProblemsTests
{
	public class Powxn
	{
		[Fact]
		public void TestMyPow_Case1()
		{
			// Arrange
			double x = 2.00000;
			int n = 10;
			double expected = 1024.00000;

			// Act
			double result = LC.Problems.Powxn.MyPow(x, n);

			// Assert
			Assert.Equal(expected, result, 5);
		}

		[Fact]
		public void TestMyPow_Case2()
		{
			// Arrange
			double x = 2.10000;
			int n = 3;
			double expected = 9.26100;

			// Act
			double result = LC.Problems.Powxn.MyPow(x, n);

			// Assert
			Assert.Equal(expected, result, 5);
		}

		[Fact]
		public void TestMyPow_Case3()
		{
			// Arrange
			double x = 2.00000;
			int n = -2;
			double expected = 0.25000;

			// Act
			double result = LC.Problems.Powxn.MyPow(x, n);

			// Assert
			Assert.Equal(expected, result, 5);
		}

		[Fact]
		public void TestMyPow_Case4()
		{
			// Arrange
			double x = 0.44528;
			int n = 0;
			double expected = 1.00000;

			// Act
			double result = LC.Problems.Powxn.MyPow(x, n);

			// Assert
			Assert.Equal(expected, result, 5);
		}

		[Fact]
		public void TestMyPow_Case5()
		{
			// Arrange
			double x = 2.00000;
			int n = -2147483648;
			double expected = 0.00000;

			// Act
			double result = LC.Problems.Powxn.MyPow(x, n);

			// Assert
			Assert.Equal(expected, result, 5);
		}
	}
}
