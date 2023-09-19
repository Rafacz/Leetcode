namespace LC.test.String
{
	public class TextJustification
	{
		[Fact]
		public void Example1()
		{
			string[] words = { "This", "is", "an", "example", "of", "text", "justification." };
			int maxWidth = 16;
			List<string> expectedOutput = new List<string>
		{
			"This    is    an",
			"example  of text",
			"justification.  "
		};

			IList<string> result = LC.String.TextJustification.FullJustify(words, maxWidth);
			Assert.Equal(expectedOutput, result);
		}

		[Fact]
		public void Example2()
		{
			string[] words = { "What", "must", "be", "acknowledgment", "shall", "be" };
			int maxWidth = 16;
			List<string> expectedOutput = new List<string>
			{
				"What   must   be",
				"acknowledgment  ",
				"shall be        "
			};

			IList<string> result = LC.String.TextJustification.FullJustify(words, maxWidth);
			Assert.Equal(expectedOutput, result);
		}

		[Fact]
		public void Example3()
		{
			string[] words = { "Science", "is", "what", "we", "understand", "well", "enough", "to", "explain", "to", "a", "computer.", "Art", "is", "everything", "else", "we", "do" };
			int maxWidth = 20;
			List<string> expectedOutput = new List<string>
			{
				"Science  is  what we",
				"understand      well",
				"enough to explain to",
				"a  computer.  Art is",
				"everything  else  we",
				"do                  "
			};

			IList<string> result = LC.String.TextJustification.FullJustify(words, maxWidth);
			Assert.Equal(expectedOutput, result);
		}

		[Fact]
		public void Example4()
		{
			string[] words = { "The", "important", "thing", "is", "not", "to", "stop", "questioning.", "Curiosity", "has", "its", "own", "reason", "for", "existing." };
			int maxWidth = 17;
			List<string> expectedOutput = new List<string>
			{
				"The     important",
				"thing  is  not to",
				"stop questioning.",
				"Curiosity has its",
				"own   reason  for",
				"existing.        "
			};

			IList<string> result = LC.String.TextJustification.FullJustify(words, maxWidth);
			Assert.Equal(expectedOutput, result);
		}

		[Fact]
		public void Example5()
		{
			string[] words = { "ask", "not", "what", "your", "country", "can", "do", "for", "you", "ask", "what", "you", "can", "do", "for", "your", "country" };
			int maxWidth = 16;
			List<string> expectedOutput = new List<string>
			{
				"ask   not   what",
				"your country can",
				"do  for  you ask",
				"what  you can do",
				"for your country"
			};

			IList<string> result = LC.String.TextJustification.FullJustify(words, maxWidth);
			Assert.Equal(expectedOutput, result);
		}
	}
}
