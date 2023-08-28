namespace LC
{
	//242. Valid Anagram
	public class ValidAnagram
	{
		public static bool IsAnagram(string s, string t)
		{
			if (s.Length != t.Length) return false;

			int[] chars = new int[26];

			for (int i = 0; i < s.Length; i++)
			{
				chars[s[i] - 'a'] += 1;
				chars[t[i] - 'a'] -= 1;
			}

			foreach (int c in chars)
			{
				if (c != 0)
				{
					return false;
				}
			}

			return true;
		}
	}
}
