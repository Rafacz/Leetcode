using System.Text;

namespace LC.String
{
	//6. Zigzag Conversion
	public class ZigzagConversion
	{
		public static string Convert(string s, int numRows)
		{
			if (numRows == 1 || s.Length < 3) return s;

			int[] indexes = new int[s.Length];
			char[] characters = new char[s.Length];
			int index = 0;
			bool add = true;

			for (int i = 0; i < s.Length; i++)
			{
				if (index == numRows - 1) add = false;
				if (index == 0) add = true;

				indexes[i] = index;
				characters[i] = s[i];

				if (add)
					index++;
				else
					index--;
			}

			StringBuilder sb = new StringBuilder();

			for (int i = 0; i < numRows; i++)
			{
				for (int j = 0; j < s.Length; j++)
				{
					if (indexes[j] == i)
					{
						sb.Append(characters[j]);
					}
				}
			}

			return sb.ToString();
		}
	}
}
