namespace LC.test.ProblemsTests
{
	public class ReverseBits
	{
		[Fact]
		public void Example1_Test()
		{
			// Arrange
			uint binaryInt = 43261596;
			uint expectedOutput = 964176192;

			// Act
			uint actualOutput = LC.Problems.ReverseBits.reverseBits(binaryInt);

			// Assert
			Assert.Equal(expectedOutput, actualOutput);
		}

		[Fact]
		public void Example2_Test()
		{
			// Arrange
			uint binaryInt = 4294967293;
			uint expectedOutput = 3221225471;

			// Act
			uint actualOutput = LC.Problems.ReverseBits.reverseBits(binaryInt);

			// Assert
			Assert.Equal(expectedOutput, actualOutput);
		}
	}
}
