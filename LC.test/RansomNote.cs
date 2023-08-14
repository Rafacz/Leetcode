namespace LC.test
{
	public class RansomNote
	{

		[Fact]
		public void CanConstructRansomNote_Example1_ReturnsFalse()
		{
			string ransomNote = "a";
			string magazine = "b";

			bool result = LC.RansomNote.CanConstruct(ransomNote, magazine);

			Assert.False(result);
		}

		[Fact]
		public void CanConstructRansomNote_Example2_ReturnsFalse()
		{
			string ransomNote = "aa";
			string magazine = "ab";

			bool result = LC.RansomNote.CanConstruct(ransomNote, magazine);

			Assert.False(result);
		}

		[Fact]
		public void CanConstructRansomNote_Example3_ReturnsTrue()
		{
			string ransomNote = "aa";
			string magazine = "aab";

			bool result = LC.RansomNote.CanConstruct(ransomNote, magazine);

			Assert.True(result);
		}
	}
}
