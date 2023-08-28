namespace LC.Problems
{
	//205. Isomorphic Strings
	public static class IsomorphicStrings
	{
		public static bool IsIsomorphic(string s, string t)
		{
			if (s.Length != t.Length)
				return false;

			char l1;
			char l2;

			for (int p1 = 0; p1 < s.Length; p1++)
			{
				l1 = s[p1];
				l2 = t[p1];

				for (int p2 = p1 + 1; p2 < t.Length; p2++)
				{
					if (s[p2] == l1 || t[p2] == l2)
					{
						if (s[p2] != l1 || t[p2] != l2)
						{
							return false;
						}
					}
				}
			}

			return true;
		}
	}
}
