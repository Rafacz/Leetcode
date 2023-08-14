namespace LC.test
{
	public class ReverseWordsInAString
	{
		[Fact]
		public void ReverseWords_ShouldReverseWordsInString()
		{
			// Arrange
			string input = "the sky is blue";
			string expectedOutput = "blue is sky the";

			// Act
			string actualOutput = LC.ReverseWordsInAString.ReverseWords(input);

			// Assert
			Assert.Equal(expectedOutput, actualOutput);
		}

		[Fact]
		public void ReverseWords_ShouldTrimLeadingAndTrailingWhitespace()
		{
			// Arrange
			string input = "  hello world  ";
			string expectedOutput = "world hello";

			// Act
			string actualOutput = LC.ReverseWordsInAString.ReverseWords(input);

			// Assert
			Assert.Equal(expectedOutput, actualOutput);
		}

		[Fact]
		public void ReverseWords_ShouldHandleMultipleSpacesBetweenWords()
		{
			// Arrange
			string input = "a good   example";
			string expectedOutput = "example good a";

			// Act
			string actualOutput = LC.ReverseWordsInAString.ReverseWords(input);

			// Assert
			Assert.Equal(expectedOutput, actualOutput);
		}
	}
}
