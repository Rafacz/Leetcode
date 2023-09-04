namespace LC.Problems
{
	//49. Group Anagrams
	public static class GroupAnagram
	{
		public static IList<IList<string>> GroupAnagrams(string[] strs)
		{
			var dict = new Dictionary<string, List<string>>();

			foreach (var str in strs)
			{
				var charArr = str.ToCharArray();
				Array.Sort(charArr);
				var sortedStr = new string(charArr);

				if (!dict.ContainsKey(sortedStr))
				{
					dict[sortedStr] = new List<string>();
				}

				dict[sortedStr].Add(str);
			}
			return new List<IList<string>>(dict.Values);
		}
	}
}
