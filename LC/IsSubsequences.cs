namespace LC
{
	public static class IsSubsequences
	{
		public static bool IsSubsequence(string s, string t)
		{
			if (string.IsNullOrEmpty(s)) return true;

			bool result = false;
			int p = 0;

			for (int i = 0; i < s.Length; i++)
			{
				if (p == t.Length)
				{
					return false;
				}

				result = false;
				for (int x = p; x < t.Length; x++)
				{
					if (s[i] == t[x])
					{
						result = true;
						p = x + 1;
						break;
					}
				}

				if (!result)
				{
					return false;
				}
			}

			return result;
		}
	}
}
