namespace LC.test
{
	//392. Is Subsequence
	public class IsSubsequence
	{
		[Fact]
		public void IsSubsequence_Example1_ReturnsTrue()
		{
			string s = "abc";
			string t = "ahbgdc";

			bool result = LC.IsSubsequences.IsSubsequence(s, t);

			Assert.True(result);
		}

		[Fact]
		public void IsSubsequence_Example2_ReturnsFalse()
		{
			string s = "axc";
			string t = "ahbgdc";

			bool result = LC.IsSubsequences.IsSubsequence(s, t);

			Assert.False(result);
		}

		[Fact]
		public void IsSubsequence_Example3_ReturnsFalse()
		{
			string s = "";
			string t = "ahbgdc";

			bool result = LC.IsSubsequences.IsSubsequence(s, t);

			Assert.True(result);
		}

		[Fact]
		public void IsSubsequence_Example4_ReturnsFalse()
		{
			string s = "aaaaaa";
			string t = "bbaaaa";

			bool result = LC.IsSubsequences.IsSubsequence(s, t);

			Assert.False(result);
		}
	}
}
