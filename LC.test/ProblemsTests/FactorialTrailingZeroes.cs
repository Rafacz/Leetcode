namespace LC.test.ProblemsTests
{
	public class FactorialTrailingZeroes
	{
		[Fact]
		public void TestTrailingZeroes_Case1()
		{
			// Arrange
			int input = 3;
			int expected = 0;

			// Act
			int result = LC.Problems.FactorialTrailingZeroes.TrailingZeroes(input); //6

			// Assert
			Assert.Equal(expected, result);
		}

		[Fact]
		public void TestTrailingZeroes_Case2()
		{
			// Arrange
			int input = 5;
			int expected = 1;

			// Act
			int result = LC.Problems.FactorialTrailingZeroes.TrailingZeroes(input); //120

			// Assert
			Assert.Equal(expected, result);
		}

		[Fact]
		public void TestTrailingZeroes_Case3()
		{
			// Arrange
			int input = 0;
			int expected = 0;

			// Act
			int result = LC.Problems.FactorialTrailingZeroes.TrailingZeroes(input);

			// Assert
			Assert.Equal(expected, result);
		}

		[Fact]
		public void TestTrailingZeroes_Case4()
		{
			// Arrange
			int input = 7;
			int expected = 1;

			// Act
			int result = LC.Problems.FactorialTrailingZeroes.TrailingZeroes(input);

			// Assert
			Assert.Equal(expected, result);
		}

		[Fact]
		public void TestTrailingZeroes_Case5()
		{
			// Arrange
			int input = 13;
			int expected = 2;

			// Act
			int result = LC.Problems.FactorialTrailingZeroes.TrailingZeroes(input);

			// Assert
			Assert.Equal(expected, result);
		}

		[Fact]
		public void TestTrailingZeroes_Case6()
		{
			// Arrange
			int input = 30;
			int expected = 7;

			// Act
			int result = LC.Problems.FactorialTrailingZeroes.TrailingZeroes(input);

			// Assert
			Assert.Equal(expected, result);
		}


		[Fact]
		public void TestTrailingZeroes_Case7()
		{
			// Arrange
			int input = 50;
			int expected = 12;

			// Act
			int result = LC.Problems.FactorialTrailingZeroes.TrailingZeroes(input);

			// Assert
			Assert.Equal(expected, result);
		}
	}
}
