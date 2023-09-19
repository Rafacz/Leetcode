namespace LC.test.String
{
	public class ZigzagConversion
	{
		[Fact]
		public void Example1()
		{
			// Arrange
			string s = "PAYPALISHIRING";
			int numRows = 3;
			string expected = "PAHNAPLSIIGYIR";

			// Act
			string result = LC.String.ZigzagConversion.Convert(s, numRows);

			// Assert
			Assert.Equal(expected, result);
		}

		[Fact]
		public void Example2()
		{
			// Arrange
			string s = "PAYPALISHIRING";
			int numRows = 4;
			string expected = "PINALSIGYAHRPI";

			// Act
			string result = LC.String.ZigzagConversion.Convert(s, numRows);

			// Assert
			Assert.Equal(expected, result);
		}

		[Fact]
		public void Example3()
		{
			// Arrange
			string s = "A";
			int numRows = 1;
			string expected = "A";

			// Act
			string result = LC.String.ZigzagConversion.Convert(s, numRows);

			// Assert
			Assert.Equal(expected, result);
		}

		[Fact]
		public void Example4()
		{
			// Arrange
			string s = "AB";
			int numRows = 1;
			string expected = "AB";

			// Act
			string result = LC.String.ZigzagConversion.Convert(s, numRows);

			// Assert
			Assert.Equal(expected, result);
		}

		[Fact]
		public void Example5()
		{
			// Arrange
			string s = "ABC";
			int numRows = 2;
			string expected = "ACB";

			// Act
			string result = LC.String.ZigzagConversion.Convert(s, numRows);

			// Assert
			Assert.Equal(expected, result);
		}

		[Fact]
		public void Example6()
		{
			// Arrange
			string s = "ABC";
			int numRows = 3;
			string expected = "ABC";

			// Act
			string result = LC.String.ZigzagConversion.Convert(s, numRows);

			// Assert
			Assert.Equal(expected, result);
		}
	}
}
