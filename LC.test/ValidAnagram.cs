namespace LC.test
{
	public class ValidAnagram
	{
		[Fact]
		public void TestIsAnagram_Example1()
		{
			// Arrange
			string s = "anagram";
			string t = "nagaram";
			bool expectedOutput = true;

			// Act
			bool actualOutput = LC.ValidAnagram.IsAnagram(s, t);

			// Assert
			Assert.Equal(expectedOutput, actualOutput);
		}

		[Fact]
		public void TestIsAnagram_Example2()
		{
			// Arrange
			string s = "rat";
			string t = "car";
			bool expectedOutput = false;

			// Act
			bool actualOutput = LC.ValidAnagram.IsAnagram(s, t);

			// Assert
			Assert.Equal(expectedOutput, actualOutput);
		}
	}
}
