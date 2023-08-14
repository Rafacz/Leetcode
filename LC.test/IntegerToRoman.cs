namespace LC.test
{
	public class IntegerToRoman
	{
		[Fact]
		public void ConvertToRomanNumeral_1()
		{
			// Arrange
			int num = 3;
			string expected = "III";

			// Act
			string result = LC.IntegerToRoman.IntToRoman(num);

			// Assert
			Assert.Equal(expected, result);
		}

		[Fact]
		public void ConvertToRomanNumeral_2()
		{
			// Arrange
			int num = 58;
			string expected = "LVIII";

			// Act
			string result = LC.IntegerToRoman.IntToRoman(num);

			// Assert
			Assert.Equal(expected, result);
		}

		[Fact]
		public void ConvertToRomanNumeral_3()
		{
			// Arrange
			int num = 1994;
			string expected = "MCMXCIV";

			// Act
			string result = LC.IntegerToRoman.IntToRoman(num);

			// Assert
			Assert.Equal(expected, result);
		}
	}
}
