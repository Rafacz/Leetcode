using System.Text;

namespace LC.Problems
{
	//383. Ransom Note
	public static class RansomNote
	{
		public static bool CanConstruct(string ransomNote, string magazine)
		{
			StringBuilder sb = new StringBuilder(ransomNote);

			for (int i = 0; i < magazine.Length; i++)
			{
				for (int x = 0; x < sb.Length; x++)
				{
					if (magazine[i] == sb[x])
					{
						sb.Remove(x, 1);
						break;
					}
				}
			}

			if (sb.Length == 0)
			{
				return true;
			}

			return false;
		}
	}
}
