namespace LC.test.ProblemsTests
{
	public class HappyNumber
	{
		[Fact]
		public void IsHappyNumber_InputIs19_ReturnsTrue()
		{
			int n = 19;
			bool expected = true;

			bool actual = LC.Problems.HappyNumber.IsHappy(n);

			Assert.Equal(expected, actual);
		}

		[Fact]
		public void IsHappyNumber_InputIs2_ReturnsFalse()
		{
			int n = 2;
			bool expected = false;

			bool actual = LC.Problems.HappyNumber.IsHappy(n);

			Assert.Equal(expected, actual);
		}

		[Fact]
		public void IsHappyNumber_InputIs3_ReturnsFalse()
		{
			int n = 3;
			bool expected = false;

			bool actual = LC.Problems.HappyNumber.IsHappy(n);

			Assert.Equal(expected, actual);
		}

		[Fact]
		public void IsHappyNumber_InputIs1999999999_ReturnsFalse()
		{
			int n = 1999999999;
			bool expected = false;

			bool actual = LC.Problems.HappyNumber.IsHappy(n);

			Assert.Equal(expected, actual);
		}
	}
}
