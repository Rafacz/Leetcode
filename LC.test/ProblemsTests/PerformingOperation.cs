namespace LC.test.ProblemsTests
{
	public class PerformingOperation
	{
		[Fact]
		public void Example1()
		{
			// Arrange
			string[] operations = { "--X", "X++", "X++" };
			int result = Problems.PerformingOperations.FinalValueAfterOperations(operations);

			// Act & Assert
			Assert.Equal(1, result);
		}

		[Fact]
		public void Example2()
		{
			// Arrange
			string[] operations = { "++X", "++X", "X++" };
			int result = Problems.PerformingOperations.FinalValueAfterOperations(operations);

			// Act & Assert
			Assert.Equal(3, result);
		}

		[Fact]
		public void Example3()
		{
			// Arrange
			string[] operations = { "X++", "++X", "--X", "X--" };
			int result = Problems.PerformingOperations.FinalValueAfterOperations(operations);

			// Act & Assert
			Assert.Equal(0, result);
		}
	}
}
