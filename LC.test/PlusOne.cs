namespace LC.test
{
	public class PlusOne
	{
		[Fact]
		public void TestExample1()
		{
			int[] input = { 1, 2, 3 };
			int[] expected = { 1, 2, 4 };
			int[] result = LC.PlusOne.PlusOn(input);
			Assert.Equal(expected, result);
		}

		[Fact]
		public void TestExample2()
		{
			int[] input = { 4, 3, 2, 1 };
			int[] expected = { 4, 3, 2, 2 };
			int[] result = LC.PlusOne.PlusOn(input);
			Assert.Equal(expected, result);
		}

		[Fact]
		public void TestExample3()
		{
			int[] input = { 9 };
			int[] expected = { 1, 0 };
			int[] result = LC.PlusOne.PlusOn(input);
			Assert.Equal(expected, result);
		}

		[Fact]
		public void TestExample4()
		{
			int[] input = { 9, 9 };
			int[] expected = { 1, 0, 0 };
			int[] result = LC.PlusOne.PlusOn(input);
			Assert.Equal(expected, result);
		}

		[Fact]
		public void TestExample5()
		{
			int[] input = { 9, 9, 9 };
			int[] expected = { 1, 0, 0, 0 };
			int[] result = LC.PlusOne.PlusOn(input);
			Assert.Equal(expected, result);
		}

		[Fact]
		public void TestExample6()
		{
			int[] input = { 8, 9, 9, 9 };
			int[] expected = { 9, 0, 0, 0 };
			int[] result = LC.PlusOne.PlusOn(input);
			Assert.Equal(expected, result);
		}

		[Fact]
		public void TestExample7()
		{
			int[] input = { 9, 8, 9 };
			int[] expected = { 9, 9, 0 };
			int[] result = LC.PlusOne.PlusOn(input);
			Assert.Equal(expected, result);
		}
	}
}
