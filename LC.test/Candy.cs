namespace LC.test
{
	public class Candy
	{
		[Fact]
		public void CalculateTotalRating1()
		{
			// Arrange
			var ratings = new int[] { 1, 0, 2 };
			var expectedTotalRating = 5;

			// Act
			var totalRating = LC.Candy.CandyCalculate(ratings);

			// Assert
			Assert.Equal(expectedTotalRating, totalRating);
		}

		[Fact]
		public void CalculateTotalRating2()
		{
			// Arrange
			var ratings = new int[] { 1, 2, 2 };
			var expectedTotalRating = 4;

			// Act
			var totalRating = LC.Candy.CandyCalculate(ratings);

			// Assert
			Assert.Equal(expectedTotalRating, totalRating);
		}
	}
}
