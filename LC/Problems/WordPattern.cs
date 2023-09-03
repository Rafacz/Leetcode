namespace LC.Problems
{
	public class WordPattern
	{
		//290. Word Pattern
		public static bool WordPatterns(string pattern, string s)
		{
			var dict = new Dictionary<char, string>();
			var words = s.Split(' ');

			if (pattern.Length != words.Length) return false;

			for (int i = 0; i < pattern.Length; i++)
			{
				if (dict.ContainsKey(pattern[i]) || dict.ContainsValue(words[i]))
				{
					if (dict.ContainsKey(pattern[i]) && dict[pattern[i]] != words[i]) return false;
					if (!dict.TryGetValue(pattern[i], out words[i]!)) return false;
				}
				else
				{
					dict.Add(pattern[i], words[i]);
				}
			}

			return true;
		}
	}
}
