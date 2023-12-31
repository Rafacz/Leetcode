﻿namespace LC.test.ProblemsTests
{
	public class GroupAnagram
	{
		[Fact]
		public void GroupAnagrams_Example1_ReturnsCorrectResult()
		{
			// Arrange
			string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
			string[][] expectedOutput = { new string[] { "eat", "tea", "ate" }, new string[] { "tan", "nat" }, new string[] { "bat" } };

			// Act
			var result = Problems.GroupAnagram.GroupAnagrams(strs);

			// Assert
			Assert.Equal(expectedOutput, result);
		}

		[Fact]
		public void GroupAnagrams_Example2_ReturnsCorrectResult()
		{
			// Arrange
			string[] strs = { "" };
			string[][] expectedOutput = { new string[] { "" } };

			// Act
			var result = Problems.GroupAnagram.GroupAnagrams(strs);

			// Assert
			Assert.Equal(expectedOutput, result);
		}

		[Fact]
		public void GroupAnagrams_Example3_ReturnsCorrectResult()
		{
			// Arrange
			string[] strs = { "a" };
			string[][] expectedOutput = { new string[] { "a" } };

			// Act
			var result = Problems.GroupAnagram.GroupAnagrams(strs);

			// Assert
			Assert.Equal(expectedOutput, result);
		}
	}
}
