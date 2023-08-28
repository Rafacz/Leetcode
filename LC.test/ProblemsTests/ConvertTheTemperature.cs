namespace LC.test.ProblemsTests
{
	public class ConvertTheTemperature
	{
		[Fact]
		public void ConvertCelsiusToKelvinAndFahrenheit_WithValidInput_ReturnsCorrectValues()
		{
			// Arrange
			double celsius = 36.50;
			double[] expected = { 309.65000, 97.70000 };

			// Act
			double[] actual = LC.Problems.ConvertTheTemperature.ConvertTemperature(celsius);

			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void ConvertCelsiusToKelvinAndFahrenheit_WithAnotherValidInput_ReturnsCorrectValues()
		{
			// Arrange
			double celsius = 122.11;
			double[] expected = { 395.26000, 251.79800 };

			// Act
			double[] actual = LC.Problems.ConvertTheTemperature.ConvertTemperature(celsius);

			// Assert
			Assert.Equal(expected, actual);
		}
	}
}
