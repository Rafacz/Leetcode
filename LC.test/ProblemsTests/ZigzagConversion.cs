namespace LC.test.ProblemsTests
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
			string result = LC.Problems.ZigzagConversion.Convert(s, numRows);

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
			string result = LC.Problems.ZigzagConversion.Convert(s, numRows);

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
			string result = LC.Problems.ZigzagConversion.Convert(s, numRows);

			// Assert
			Assert.Equal(expected, result);
		}
	}
}
