namespace LC.String
{
	//3. Longest Substring Without Repeating Characters
	public static class LongesSubstring
	{
		public static int LengthOfLongestSubstring(string s)
		{
			if (s is null) return 0;

			var distinct = new HashSet<char>();

			int max = 0;
			int p = 0;

			for (int i = 0; i < s.Length; i++)
			{
				if (distinct.Contains(s[i]))
				{
					if (max < distinct.Count)
					{
						max = distinct.Count;
					}

					distinct.Clear();
					i = p++;
				}

				distinct.Add(s[i]);
			}

			return Math.Max(max, distinct.Count);
		}
	}
}
