namespace LC.test.ProblemsTests
{
	public class SpiralMatrix
	{
		[Fact]
		public void TestMatrixTransformation1()
		{
			// Arrange
			int[][] matrix = new int[][] {
			new int[] { 1, 2, 3 },
			new int[] { 4, 5, 6 },
			new int[] { 7, 8, 9 }
		};

			IList<int> expectedOutput = new List<int> { 1, 2, 3, 6, 9, 8, 7, 4, 5 };

			// Act
			IList<int> actualOutput = LC.Problems.SpiralMatrix.SpiralOrder(matrix);

			// Assert
			Assert.Equal(expectedOutput, actualOutput);
		}

		[Fact]
		public void TestMatrixTransformation2()
		{
			// Arrange
			int[][] matrix = new int[][] {
			new int[] { 1, 2, 3, 4 },
			new int[] { 5, 6, 7, 8 },
			new int[] { 9, 10, 11, 12 }
		};

			IList<int> expectedOutput = new List<int> { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 };

			// Act
			IList<int> actualOutput = LC.Problems.SpiralMatrix.SpiralOrder(matrix);

			// Assert
			Assert.Equal(expectedOutput, actualOutput);
		}
	}
}
