namespace LC.test.ProblemsTests
{
	public class WordPattern
	{
		[Fact]
		public void TestPatternMatching_Example1()
		{
			// Arrange
			string pattern = "abba";
			string s = "dog cat cat dog";
			bool expectedOutput = true;

			// Act
			bool actualOutput = LC.Problems.WordPattern.WordPatterns(pattern, s);

			// Assert
			Assert.Equal(expectedOutput, actualOutput);
		}

		[Fact]
		public void TestPatternMatching_Example2()
		{
			// Arrange
			string pattern = "abba";
			string s = "dog cat cat fish";
			bool expectedOutput = false;

			// Act
			bool actualOutput = LC.Problems.WordPattern.WordPatterns(pattern, s);

			// Assert
			Assert.Equal(expectedOutput, actualOutput);
		}

		[Fact]
		public void TestPatternMatching_Example3()
		{
			// Arrange
			string pattern = "aaaa";
			string s = "dog cat cat dog";
			bool expectedOutput = false;

			// Act
			bool actualOutput = LC.Problems.WordPattern.WordPatterns(pattern, s);

			// Assert
			Assert.Equal(expectedOutput, actualOutput);
		}
	}
}
