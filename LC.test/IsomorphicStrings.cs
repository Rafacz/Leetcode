namespace LC.test
{
	public class IsomorphicStrings
	{
		[Fact]
		public void IsAnagram_ShouldReturnTrue1()
		{
			string s = "egg";
			string t = "add";

			bool result = LC.IsomorphicStrings.IsIsomorphic(s, t);

			Assert.True(result);
		}

		[Fact]
		public void IsAnagram_ShouldReturnFalse2()
		{
			string s = "foo";
			string t = "bar";

			bool result = LC.IsomorphicStrings.IsIsomorphic(s, t);

			Assert.False(result);
		}

		[Fact]
		public void IsAnagram_ShouldReturnTrue3()
		{
			string s = "paper";
			string t = "title";

			bool result = LC.IsomorphicStrings.IsIsomorphic(s, t);

			Assert.True(result);
		}

		[Fact]
		public void IsAnagram_ShouldReturnFalse4()
		{
			string s = "badc";
			string t = "baba";

			bool result = LC.IsomorphicStrings.IsIsomorphic(s, t);

			Assert.False(result);
		}
	}
}
