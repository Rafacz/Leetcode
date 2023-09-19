namespace LC.test.String
{
	public class LongesSubstring
	{
		[Fact]
		public void Test1()
		{
			// Arrange
			string s = "abcabcbb";
			int expected = 3;

			// Act
			int result = LC.String.LongesSubstring.LengthOfLongestSubstring(s);

			// Assert
			Assert.Equal(expected, result);
		}

		[Fact]
		public void Test2()
		{
			// Arrange
			string s = "bbbbb";
			int expected = 1;

			// Act
			int result = LC.String.LongesSubstring.LengthOfLongestSubstring(s);

			// Assert
			Assert.Equal(expected, result);
		}

		[Fact]
		public void Test3()
		{
			// Arrange
			string s = "pwwkew";
			int expected = 3;

			// Act
			int result = LC.String.LongesSubstring.LengthOfLongestSubstring(s);

			// Assert
			Assert.Equal(expected, result);
		}

		[Fact]
		public void Test4()
		{
			// Arrange
			string s = " ";
			int expected = 1;

			// Act
			int result = LC.String.LongesSubstring.LengthOfLongestSubstring(s);

			// Assert
			Assert.Equal(expected, result);
		}

		[Fact]
		public void Test5()
		{
			// Arrange
			string s = "aab";
			int expected = 2;

			// Act
			int result = LC.String.LongesSubstring.LengthOfLongestSubstring(s);

			// Assert
			Assert.Equal(expected, result);
		}

		[Fact]
		public void Test6()
		{
			// Arrange
			string s = "dvdf";
			int expected = 3;

			// Act
			int result = LC.String.LongesSubstring.LengthOfLongestSubstring(s);

			// Assert
			Assert.Equal(expected, result);
		}
	}
}
